using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class Music
    {
        public Music(string name, string executor, int year)
        {
            Name = name;
            this.executor = executor;
            Year = year;
        }

        public string Name { get; set; }
        public string executor { get; set; }
        public int Year { get; set; }

        public static List<Music> musics()
        {
            List<Music> musics2 = new List<Music>();
            musics2.Add(new Music("Шальная императрица", "Ирина Аллегрова", 1995));
            return musics2;
        }
    }
}
