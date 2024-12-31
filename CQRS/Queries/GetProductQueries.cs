using MediatR;

namespace CQRS.Queries
{
    public record GetProductQueries:IRequest<IEnumerable<Product>>;
    
}
