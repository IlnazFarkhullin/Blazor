using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.galleryService;

namespace WebApplication1.galleryService
{
    public interface Igalleryservice
    {
        void Save(gallery to);
        gallery GetDBpaintings(Object _id);
        List<gallery> GetDBpainting();
    }
}
