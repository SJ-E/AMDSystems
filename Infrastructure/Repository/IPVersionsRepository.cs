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
    public class IPVersionsRepository : IIPVersions
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }

        public IPVersionsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPVersionsModel iPVersionsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPVersionsModel> FilterIPVersions()
        {
            throw new NotImplementedException();
        }

        public IPVersionsModel FilterIPVersions(int id)
        {
            throw new NotImplementedException();
        }
    }
}
