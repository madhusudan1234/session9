using Session_8_partone.Model;

namespace Session_8_partone.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> product;
        public ProductService()
        {
            product = new List<Product>()
            {
                new Product() {Id=1,Pname="Xiomi",Price=2000}
            };
        }
        public IEnumerable<Product> GetAllItems()
        {
            return product;
        }
    }
}

