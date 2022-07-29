using AutoMapper;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandMapping:Profile
    {
        public CreateProductCommandMapping()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
        }
    }
}
