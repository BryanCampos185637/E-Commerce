using Microsoft.EntityFrameworkCore;
using Model;
using Model.DTO;
using Model.DTO.Pagination;
using PersistenceData;
using Service.Contracts;
using Service.HelperPagination;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductoService : IProductoService
    {
        private readonly AplicationDbContext db;
        public ProductoService(AplicationDbContext context)
        {
            db = context;
        }
        public async Task Add(Product model)
        {
            await db.Products.AddAsync(model);
        }

        public async Task Delete(int id)
        {
            var model = await db.Products.FindAsync(id);
            model.Status = false;
        }

        public async Task<ProductDTO> FindById(int id)
        {
            var product = await db.Products.FindAsync(id);
            return new ProductDTO
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                SupplierId = product.SupplierId,
                Name = product.Name,
                Description = product.Description,
                Code = product.Code,
                Price = product.Price,
                Quantity = product.Quantity
            };
        }

        public async Task<DataCollection<ProductDTO>> Pagination(DataCollection<ProductDTO> model)
        {
            return await db.Products.Include(x => x.Category).Include(p => p.Supplier).Where(p => p.Status == true)
                .OrderByDescending(x => x.ProductId).Select(p => new ProductDTO
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Description = p.Description,
                    CategoryName = p.Category.Name,
                    SupplierName = p.Supplier.Name
                }).AsQueryable().PagedAsync(model.Page, model.Take);
        }

        public async Task Update(Product model)
        {
            var modelo = await db.Products.FindAsync(model.CategoryId);
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
