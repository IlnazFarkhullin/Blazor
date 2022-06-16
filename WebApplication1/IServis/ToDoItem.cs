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
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; } = ObjectId.GenerateNewId().ToString();

        public string Name { get; set; }
        public bool IsDone { get; set; }

       
    //public static  List<ToDoItem> ShowToItem()
    //{
    //    var todo = new MongoClient("mongodb://localhost");
    //    var database = todo.GetDatabase("ToDoList");
    //    var collection = database.GetCollection<ToDoItem>("List");
    //    return collection.Find(x => true).ToList();
    //}
    }

    //public static List<students_class> ShowStudents()
    //{
    //    var stud = new MongoClient("mongodb://localhost"); // подключение
    //    var database = stud.GetDatabase("guide"); // бд
    //    var collection = database.GetCollection<BD_class.students_class>("Students"); // коллекция внутри БД
    //    return collection.Find(x => true).ToList(); // возвращение всех данных из коллекции
    //}
}
