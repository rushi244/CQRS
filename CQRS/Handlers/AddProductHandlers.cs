using CQRS.Commands;
using MediatR;

namespace CQRS.Handlers
{
    public class AddProductHandlers : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly FakeDataStor _fakeDataStor;
         
        public AddProductHandlers(FakeDataStor fakeDataStor)
        {
            _fakeDataStor = fakeDataStor;
        }

        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStor.AddProduct(request.product);
            return Unit.Value;
        }
    }
}
