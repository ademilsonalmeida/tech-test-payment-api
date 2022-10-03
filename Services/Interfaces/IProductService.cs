using tech_test_payment.ViewModels.Product;

namespace tech_test_payment.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductViewModel> GetById(Guid id);
        Task<IEnumerable<ProductViewModel>> GetAll();
        Task<ProductViewModel> Create(CreateProductViewModel createProductViewModel);
        Task<ProductViewModel> Update(UpdateProductViewModel updateProductViewModel);
        Task<ProductViewModel> Delete(Guid id);
    }
}