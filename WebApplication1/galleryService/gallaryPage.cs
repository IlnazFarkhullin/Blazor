using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.galleryService;

namespace WebApplication1.galleryService
{
    public class gallaryPage
    {
        Igalleryservice _gallaryService = null;
        public gallaryPage(Igalleryservice gallaryService)
        {
            _gallaryService = gallaryService;
        }
        public string SaveInfomation(byte [] fileBytes, gallery gallery) 
        {
            gallery.photo = fileBytes;
            return _gallaryService.Save(gallery);
        }

        public  byte[] GetImage(string sBase)
        {
            byte[] bytes = null;
            if (!string.IsNullOrEmpty(sBase))
            {
                bytes = Convert.FromBase64String(sBase);
            }
            return bytes;
        }

        public gallery getimg(string gallID)
        {
            var image = _gallaryService.GetDBpaintings(gallID);
            image.photo = this.GetImage(Convert.ToBase64String(image.photo));
            image.ImageUrl = string.Format("data:image/jpg;base64,{0}",Convert.ToBase64String(image.photo));
            return image;

        }
    }
}
