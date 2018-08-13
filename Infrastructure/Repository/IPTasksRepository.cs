using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPTasksRepository : IIPTasks
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPTasksRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPTasksModel iPTasksModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPTasksModel> FilterIPTasks()
        {
            throw new NotImplementedException();
        }

        public IPTasksModel FilterIPTasks(int id)
        {
            throw new NotImplementedException();
        }
    }
}
