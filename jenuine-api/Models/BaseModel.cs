using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Its.Jenuiue.Api.Models
{
    public class BaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public DateTime ModifiedDtm { get; set; }
        
        public DateTime CreatedDtm { get; set; }
    }
}
