using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DataBaseStudent
{
    public class ServicStudents : IStudentService
    {
        private MongoClient _todo = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<DBStudents> _collection = null;

        public ServicStudents()
        {
            _todo = new MongoClient("mongodb://localhost");
            _database = _todo.GetDatabase("guide");
            _collection = _database.GetCollection<DBStudents>("Students");

        }

        public string Delete(string Studid)
        {
            _collection.DeleteOne(z => z._id == Studid);
            return "Deleted";
        }

        public List<DBStudents> GetDBStudent()
        {
            return _collection.Find(FilterDefinition<DBStudents>.Empty).ToList();
        }

        public DBStudents GetDBStudents(object _id)
        {
            return _collection.Find(x => x._id == x._id).FirstOrDefault();
        }

        public void Save(DBStudents to)
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
    }
}
