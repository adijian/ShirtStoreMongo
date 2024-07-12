using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Text.Json.Serialization;

namespace PolosoBackend.Models
{
    public class Shirt
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("Name")]
        [JsonPropertyName("Name")]
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public List<string> Sizes { get; set; } = [];
        public List<string> Colors { get; set; } = [];
    }
}