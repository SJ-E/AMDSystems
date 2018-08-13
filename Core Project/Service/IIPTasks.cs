using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPTasks
    {
        IEnumerable<IPTasksModel> FilterIPTasks();
        IPTasksModel FilterIPTasks(int id);
        void Add(IPTasksModel iPTasksModel);
    }
}
