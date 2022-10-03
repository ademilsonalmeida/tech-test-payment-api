using tech_test_payment.Utils;

namespace tech_test_payment.ViewModels.Sale
{
    public class UpdateSaleViewModel
    {
        public Guid Id { get; set; }
        public SaleStatusEnum Status { get; set; }
    }
}