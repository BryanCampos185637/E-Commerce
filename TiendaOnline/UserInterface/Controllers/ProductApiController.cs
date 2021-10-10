using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using Model.DTO.Pagination;
using System;
using System.Threading.Tasks;
using UserInterface.Models;

namespace UserInterface.Controllers
{
    public class ProductApiController : UnitOfWorkController
    {
        [HttpGet("{page}")]
        public async Task<ApiResult> GetAll(int page = 1)
        {
            try
            {
                return new ApiResult(await _UnitOfWork.ProductoService().Pagination(new DataCollection<ProductDTO> { Page = page, Take = 5 }));
            }
            catch (Exception ex)
            {
                return new ApiResult(ex.Message, ex);
            }
        }
        [HttpGet("obtenerPorId")]
        public async Task<ApiResult>FindById(int id)
        {
            try
            {
                return new ApiResult(await _UnitOfWork.ProductoService().FindById(id));
            }
            catch (Exception ex)
            {
                return new ApiResult(ex.Message, ex);
            }
        }
        [HttpPost("insertar")]
        public async Task<ActionResult<ApiResult>> Post(ProductDTO product)
        {
            try
            {
                await _UnitOfWork.ProductoService().Add(new Model.Product
                {
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    Code = Guid.NewGuid().ToString(),
                    CategoryId = product.CategoryId == 0 ? 1 : product.CategoryId,
                    SupplierId = product.SupplierId == 0 ? 1 : product.SupplierId,
                    DateCreation = DateTime.UtcNow,
                    UserCreation = Guid.NewGuid().ToString(),
                    Status = true
                });
                return new ApiResult(await _UnitOfWork.SaveChangeAsync());
            }
            catch (Exception ex)
            {
                return new ApiResult(ex.Message, ex);
            }
        }
        [HttpPut("modificar")]
        public async Task<ActionResult<ApiResult>> Put(ProductDTO product)
        {
            try
            {
                await _UnitOfWork.ProductoService().Update(new Model.Product
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Quantity = product.Quantity,
                    Code = Guid.NewGuid().ToString(),
                    CategoryId = product.CategoryId == 0 ? 1 : product.CategoryId,
                    SupplierId = product.SupplierId == 0 ? 1 : product.SupplierId,
                    UserCreation = Guid.NewGuid().ToString(),
                    Status = true
                });
                return new ApiResult(await _UnitOfWork.SaveChangeAsync());
            }
            catch (Exception ex)
            {
                return new ApiResult(ex.Message == "" || ex.Message == null ? ex.InnerException.Message : ex.Message, ex);
            }
        }
    }
}
