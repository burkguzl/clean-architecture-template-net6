using AutoMapper;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQueryMapping:Profile
    {
        public GetProductByIdQueryMapping()
        {
            CreateMap<Product, GetProductByIdQueryResponse>().ReverseMap();
        }
    }
}
