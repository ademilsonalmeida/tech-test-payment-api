using tech_test_payment.ViewModels.SaleITem;

namespace tech_test_payment.ViewModels.Sale
{
    public class CreateSaleViewModel
    {        
        public Guid SellerId { get; set; }
        public DateTime Date { get; set; }

        public IEnumerable<CreateSaleItemsViewModel> Items { get; set; }
    }
}