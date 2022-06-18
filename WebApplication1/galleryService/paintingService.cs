using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.galleryService;

namespace WebApplication1.galleryService
{
    public class paintingService : Igalleryservice
    {
        private MongoClient _todo = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<gallery> _collection = null;

        public paintingService()
        {
            _todo = new MongoClient("mongodb://localhost");
            _database = _todo.GetDatabase("gallery");
            _collection = _database.GetCollection<gallery>("paintings");

        }
        public List<gallery> GetDBpainting()
        {
            return _collection.Find(FilterDefinition<gallery>.Empty).ToList();
        }

        public gallery GetDBpaintings(object _id)
        {
            return _collection.Find(x => x._id == x._id).FirstOrDefault();
        }

        public void Save(gallery to)
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
