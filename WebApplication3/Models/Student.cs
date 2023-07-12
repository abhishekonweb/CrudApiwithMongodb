using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization;


namespace WebApplication3.Models
{
    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; } = string.Empty;

        [BsonElement("Graduated")]
        public bool IsGraduated { get; set; }

        public string[]? Courses { get; set; }

        public string Gender { get; set; } = string.Empty;

        public int Age { get; set; }
    }
}

