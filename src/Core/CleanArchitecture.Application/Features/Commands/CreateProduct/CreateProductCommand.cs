using MediatR;

namespace CleanArchitecture.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommand:IRequest<CancellationToken>
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
    }
}
