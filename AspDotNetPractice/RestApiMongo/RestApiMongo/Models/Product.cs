using MongoDB.Bson.Serialization.Attributes;

namespace RestApiMongo.Models
{
    public class Product
    {
        [BsonId]
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public Decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
