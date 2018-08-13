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
    public class IPProjectsRepository : IIPProjects
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPProjectsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPProjectsModel iPProjectsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPProjectsModel> FilterIPProjects()
        {
            throw new NotImplementedException();
        }

        public IPProjectsModel FilterIPProjects(int id)
        {
            throw new NotImplementedException();
        }
    }
}
