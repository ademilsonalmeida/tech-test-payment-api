using Microsoft.EntityFrameworkCore;
using tech_test_payment.Contexts;
using tech_test_payment.Models;
using tech_test_payment.Repositories.Interfaces;

namespace tech_test_payment.Repositories
{
    public class SaleItemsRepository : BaseRepository<SaleItems>, ISaleItemsRepository
    {
        public SaleItemsRepository(DataContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<SaleItems>> GetAllBySaleId(Guid saleId)
        {
            return await _context.SalesItems.Where(w => w.SaleId == saleId).ToListAsync();
        }
    }
}