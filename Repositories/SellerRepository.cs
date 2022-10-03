using tech_test_payment.Contexts;
using tech_test_payment.Models;
using tech_test_payment.Repositories.Interfaces;

namespace tech_test_payment.Repositories
{
    public class SellerRepository : BaseRepository<Seller>, ISellerRepository
    {
        public SellerRepository(DataContext context) : base(context)
        {
        }
    }
}