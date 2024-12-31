using CQRS.Queries;
using MediatR;

namespace CQRS.Handlers
{                   
    public class GetProductHandlers : IRequestHandler<GetProductQueries, IEnumerable<Product>>
    {
        private readonly FakeDataStor _fakeDataStor;
        public GetProductHandlers(FakeDataStor fakeDataStor) => _fakeDataStor = fakeDataStor;
        public async Task<IEnumerable<Product>> Handle(GetProductQueries request, CancellationToken cancellationToken) => 
            await _fakeDataStor.GetAllProduct();
    }
}
