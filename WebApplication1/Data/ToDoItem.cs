using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace WebApplication1.Data
{
    public class ToDoItem
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        public string Name { get; set; }
        public bool IsDone { get; }

        public static void AddStudentToDatabase(ToDoItem newToDo)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("ToDoList");
            var collection = database.GetCollection<ToDoItem>("ToDoItem");
            collection.InsertOne(newToDo);
        }
    }
}
