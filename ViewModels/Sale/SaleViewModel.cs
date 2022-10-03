using tech_test_payment.Utils;
using tech_test_payment.ViewModels.SaleITem;
using tech_test_payment.ViewModels.Seller;

namespace tech_test_payment.ViewModels.Sale
{
    public class SaleViewModel
    {
        public Guid Id { get; set; }
        public Guid SellerId { get; set; }
        public DateTime Date { get; set; }        
        public SaleStatusEnum Status { get; set; }

        public SellerViewModel Seller { get; set; }
        public List<SaleItemsViewModel> Items { get; set; }

        public SaleViewModel()
        {
            Items = new List<SaleItemsViewModel>();
        }
    }
}