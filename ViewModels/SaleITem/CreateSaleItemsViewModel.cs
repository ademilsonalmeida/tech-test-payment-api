using System.Text.Json.Serialization;

namespace tech_test_payment.ViewModels.SaleITem
{
    public class CreateSaleItemsViewModel
    {    
        [JsonIgnore]   
        public Guid SaleId { get; set; } 
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}