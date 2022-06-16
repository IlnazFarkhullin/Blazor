using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class student
    {
        public student(string surname, string name, string patronymic, int group, string specialization)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Group = group;
            Specialization = specialization;
        }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public int Group { get; set; }
        public string Specialization { get; set; }


        public static List<student> Student()
        {
            List<student> musics2 = new List<student>();
            musics2.Add(new student("Farkhullin", "Ilnaz", "Almazovich", 323 , "programmist"));
            musics2.Add(new student("Farkhullin", "Ilnaz", "Almazovich", 323 , "programmist"));
            musics2.Add(new student("Farkhullin", "Ilnaz", "Almazovich", 323 , "programmist"));
            musics2.Add(new student("Farkhullin", "Ilnaz", "Almazovich", 323 , "programmist"));
            return musics2;
        }

    }
}
