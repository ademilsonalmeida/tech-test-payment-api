using tech_test_payment.ViewModels.Product;

namespace tech_test_payment.ViewModels.SaleITem
{
    public class SaleItemsViewModel
    {
        public Guid Id { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }

        public ProductViewModel Produtct { get; set; }
    }
}