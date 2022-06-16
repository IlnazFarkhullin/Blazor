using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.DataBaseStudent;

namespace WebApplication1.DataBaseStudent
{
     public interface IStudentService
    {
        void Save(DBStudents to);
        DBStudents GetDBStudents(Object _id);
        List<DBStudents> GetDBStudent();
        string Delete(string Studid);
    }
}
