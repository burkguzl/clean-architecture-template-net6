using CleanArchitecture.Application.Wrappers;
using MediatR;

namespace CleanArchitecture.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery:IRequest<ServiceResponse<List<GetAllProductsQueryResponse>>>
    {

    }
}
