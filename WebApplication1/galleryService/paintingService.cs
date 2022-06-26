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
        gallery _gall = new gallery();

        private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<gallery> _galleryTable = null;
         
        public paintingService()
        {
            _mongoClient = new MongoClient("mongodb://localhost:27017/");
            _database = _mongoClient.GetDatabase("gallery");
            _galleryTable = _database.GetCollection<gallery>("paintings");
        }

        public List<gallery> GetDBpainting()
        {
            return _galleryTable.Find(FilterDefinition<gallery>.Empty).ToList();
        }

        public gallery GetDBpaintings(string _id)
        {
            return _galleryTable.Find(x => x._id == _id).FirstOrDefault();
        }

        public string Save(gallery to)
        {
            var galleryObj = _galleryTable.Find(x => x._id == to._id).FirstOrDefault();
            if (galleryObj == null)
            {
                _galleryTable.InsertOne(to);
            }
            else
            {
                _galleryTable.ReplaceOne(x => x._id == to._id, to);
            }
            return "Saved";
        }
    }
}
