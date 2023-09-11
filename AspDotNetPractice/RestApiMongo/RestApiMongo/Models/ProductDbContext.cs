using MongoDB.Driver;

namespace RestApiMongo.Models
{
    public class ProductDbContext
    {
        MongoClient client;
        IMongoDatabase database;
        public ProductDbContext(IConfiguration config)
        {
            client = new MongoClient(config.GetConnectionString("mongodbConString"));
            database = client.GetDatabase(config.GetSection("DatabaseName").Value);
        }

        public IMongoCollection<Product> products => database.GetCollection<Product>("products");
    }
}
