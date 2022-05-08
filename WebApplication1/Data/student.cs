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
            List<student> students = new List<student>();
            students.Add(new student("Граница", "Дмитрий", "Cтаниславович", 323, "Программист"));
            students.Add(new student("Скидан", "Алексей", "Викторович", 323, "Программист"));
            return students;
        }

        
    }
}
