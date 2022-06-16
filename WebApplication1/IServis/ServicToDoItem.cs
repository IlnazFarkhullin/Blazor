using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IServis;
using WebApplication1.Data;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WebApplication1.IServis
{
    public class ServicToDoItem : ITodoService
    {
        private MongoClient _todo = null;
        private IMongoDatabase _database =  null;
        private IMongoCollection<ToDoItem> _collection = null;

        public ServicToDoItem()
        {
            _todo = new MongoClient("mongodb://localhost");
            _database = _todo.GetDatabase("ToDoList");
            _collection = _database.GetCollection<ToDoItem>("List");

        }

        public string  Delete(string ToDoid)
        {
            _collection.DeleteOne(z => z._id == ToDoid);
            return "Deleted";
        }

        public ToDoItem GetToDoItem(object _id)
        {
            return _collection.Find(x => x._id == x._id).FirstOrDefault();
        }

        public List<ToDoItem> GetToDoItems()
        {
            return _collection.Find(FilterDefinition<ToDoItem>.Empty).ToList();
        }

        public void Save(ToDoItem to)
        {
            var toObj = _collection.Find(x => x._id == to._id).FirstOrDefault();
            if (toObj == null)
            {
                _collection.InsertOne(to);
            }
            else
            {
                _collection.ReplaceOne(x => x._id == to._id, to);
            }

        }
       

        
        //public static List<ToDoItem> ShowToItem()
        //{
        //    var todo = new MongoClient("mongodb://localhost");
        //    var database = todo.GetDatabase("ToDoList");
        //    var collection = database.GetCollection<ToDoItem>("List");
        //    return collection.Find(x => true).ToList();
        //}
    }
}
