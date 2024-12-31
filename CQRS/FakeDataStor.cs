using System.Security.Cryptography.X509Certificates;

namespace CQRS
{
    
    public class FakeDataStor
    {
        private static List<Product> _product;

        public FakeDataStor()
        {
            _product = new List<Product>()
            {
                new Product{Id=1,Name="Test1"},
                new Product{Id=2,Name="Test3"},
                new Product{Id=3,Name="Test3"},

            };
           
        }
        public async Task AddProduct(Product p)
        {
            _product.Add(p);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProduct() => await Task.FromResult(_product);
    }
}
