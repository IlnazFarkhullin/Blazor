using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.IservaiceStud
{
    public class ServiceStudents : IStud
    {

        private MongoClient _stud = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<Student> _collection = null;
        public ()
        {
            _todo = new MongoClient("mongodb://localhost");
            _database = _todo.GetDatabase("ToDoList");
            _collection = _database.GetCollection<ToDoItem>("List");

        }
        Student IStud.GetToDoItem(object _id)
        {
            throw new NotImplementedException();
        }

        List<Student> IStud.GetToDoItems()
        {
            throw new NotImplementedException();
        }

        void IStud.Save(Student to)
        {
            throw new NotImplementedException();
        }
    }
}
