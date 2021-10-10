using Microsoft.EntityFrameworkCore;
using Model.DTO;
using PersistenceData;
using Service.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly AplicationDbContext db; 
        public SupplierService(AplicationDbContext context)
        {
            db = context;
        }
        public async Task<List<SupplierDTO>> GetAll()
        {
            return await db.Suppliers.Where(p => p.Status == true)
                .Select(p => new SupplierDTO { SupplierId = p.SupplierId, Name = p.Name }).ToListAsync();
        }
    }
}
