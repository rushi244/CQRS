using MediatR;

namespace CQRS.Commands
{
    public record AddProductCommand(Product product):IRequest;
   
}
