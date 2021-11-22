using AutoMapper;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.MappingProfiles
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, Product>();
        }
    }
}
