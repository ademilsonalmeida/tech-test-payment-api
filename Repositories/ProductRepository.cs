using tech_test_payment.Contexts;
using tech_test_payment.Models;
using tech_test_payment.Repositories.Interfaces;

namespace tech_test_payment.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
            
        }        
    }
}