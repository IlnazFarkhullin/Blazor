using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.IservaiceStud;

namespace WebApplication1.IservaiceStud
{
    interface IStud
    {
        void Save(Student to);
        Student GetToDoItem(Object _id);
        List<Student> GetToDoItems();
    }
}
