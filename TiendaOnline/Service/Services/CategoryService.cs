using Microsoft.EntityFrameworkCore;
using Model.DTO;
using PersistenceData;
using Service.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AplicationDbContext db;
        public CategoryService(AplicationDbContext context)
        {
            db = context;
        }
        public async Task<List<CategoryDTO>> GetAll()
        {
            return await db.Categories.Where(p => p.Status == true)
                .Select(p => new CategoryDTO { CategoryId = p.CategoryId, Name = p.Name, Description = p.Description }).ToListAsync();
        }
    }
}
