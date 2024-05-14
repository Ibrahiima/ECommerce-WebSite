using AutoMapper;
using Models;
using DTOs;
using ECommerceWebAPI;

namespace Services
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<UserDTOs, User>().ReverseMap();
            CreateMap<ProductDTOs, Product>().ReverseMap();
            CreateMap<CategoryDTOs, Category>().ReverseMap();
            CreateMap<OrderDTOs, Order>().ReverseMap();
            CreateMap<OrderDetailDTOs, OrderDetail>().ReverseMap();
            CreateMap<CartDTOs, Cart>().ReverseMap();
        }
    }
}
