using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Cars
    {
        public Cars(string marka, string model, string color)
        {
            Marka = marka;
            Model = model;
            Color = color;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public static List<Cars> car()
        {
            List<Cars> avto = new List<Cars>();
            avto.Add(new Cars("Lada", "Granta", "Black"));
            return avto;
        }
    }
}
