using tech_test_payment.ViewModels.Sale;

namespace tech_test_payment.Services.Interfaces
{
    public interface ISaleService
    {
        Task<SaleViewModel> GetById(Guid id);
        Task<IEnumerable<SaleViewModel>> GetAll();
        Task<SaleViewModel> Create(CreateSaleViewModel createSaleViewModel);
        Task<SaleViewModel> UpdateSaleStatus(UpdateSaleViewModel updateSaleViewModel);
    }
}