using AutoMapper;
using tech_test_payment.Models;
using tech_test_payment.ViewModels.Product;
using tech_test_payment.ViewModels.Sale;
using tech_test_payment.ViewModels.SaleITem;
using tech_test_payment.ViewModels.Seller;

namespace tech_test_payment.Services.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductViewModel, Product>();
            CreateMap<UpdateProductViewModel, Product>();

            CreateMap<Seller, SellerViewModel>().ReverseMap();
            CreateMap<CreateSellerViewModel, Seller>();
            CreateMap<UpdateSellerViewModel, Seller>();

            CreateMap<Sale, SaleViewModel>().ReverseMap();
            CreateMap<CreateSaleViewModel, Sale>();
            CreateMap<UpdateSaleViewModel, Sale>();

            CreateMap<SaleItems, SaleItemsViewModel>().ReverseMap();
            CreateMap<CreateSaleItemsViewModel, SaleItems>();            
        }
    }
}