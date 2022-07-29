using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQueryMapping:Profile
    {
        public GetAllProductsQueryMapping()
        {
            CreateMap<Product, GetAllProductsQueryResponse>().ReverseMap();
        }
    }
}
