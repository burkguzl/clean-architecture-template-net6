using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
