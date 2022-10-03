using tech_test_payment.Contexts;
using tech_test_payment.Models;
using tech_test_payment.Repositories.Interfaces;

namespace tech_test_payment.Repositories
{
    public class SaleRepository : BaseRepository<Sale>, ISaleRepository
    {
        public SaleRepository(DataContext context) : base(context)
        {
        }
    }
}