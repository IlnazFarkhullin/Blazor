using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WebApplication1.DataBaseStudent
{
    public class DBStudents
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lname { get; set; }
        public string Birth_date { get; set; }
        public string Phone { get; set; }
        public string email { get; set; }
        public string Medical_policy { get; set; }
        public string INN { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string Registration { get; set; }
    }
}
