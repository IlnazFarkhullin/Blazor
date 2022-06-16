using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.IServis;

namespace WebApplication1.IServis
{
    public interface ITodoService
    {
        void Save( ToDoItem to);
        ToDoItem GetToDoItem(Object _id);
        List<ToDoItem> GetToDoItems();
        string Delete(string ToDoid);
    }
}
