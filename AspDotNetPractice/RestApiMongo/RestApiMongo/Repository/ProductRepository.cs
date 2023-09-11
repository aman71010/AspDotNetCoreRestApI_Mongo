using MongoDB.Driver;
using RestApiMongo.Models;

namespace RestApiMongo.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext dbcontext;

        public ProductRepository(ProductDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public void AddProduct(Product prod)
        {
            dbcontext.products.InsertOne(prod);
        }

        public void DeleteProduct(int id)
        {
            dbcontext.products.DeleteOne(p => p.ProductId == id);
        }

        public List<Product> GetAllProducts()
        {
            return dbcontext.products.Find(t => true).ToList();
        }

        public Product GetProductById(int id)
        {
            return dbcontext.products.Find(p => p.ProductId == id).FirstOrDefault();
        }

        public void UpdateProduct(int id, Product prod)
        {
            var filter = Builders<Product>.Filter.Where(p => p.ProductId == id);
            var update = Builders<Product>.Update
                .Set(p => p.ProductTitle, prod.ProductTitle)
                .Set(p => p.Quantity, prod.Quantity)
                .Set(p => p.Price, prod.Price);
            dbcontext.products.UpdateOne(filter, update);
        }
    }
}
