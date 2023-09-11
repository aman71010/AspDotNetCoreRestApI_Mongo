using RestApiMongo.Models;

namespace RestApiMongo.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product prod);
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        void UpdateProduct(int id, Product prod);
        void DeleteProduct(int id);
    }
}
