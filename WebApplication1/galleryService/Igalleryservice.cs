using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.galleryService;

namespace WebApplication1.galleryService
{
    public interface Igalleryservice
    {
       string Save(gallery to);
        List<gallery> GetDBpainting();
        gallery GetDBpaintings(string _id);
    }
}
