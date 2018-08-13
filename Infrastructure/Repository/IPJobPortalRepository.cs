using Infrastructure.Data;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPJobPortalRepository:IIPJobPortal
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPJobPortalRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPJobPortalModel> FilterIPJobPortal()
        {
            throw new NotImplementedException();
        }

        public IPJobPortalModel FilterIPJobPortal(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPJobPortalModel iPJobPortalModel)
        {
            throw new NotImplementedException();
        }
    }
}
