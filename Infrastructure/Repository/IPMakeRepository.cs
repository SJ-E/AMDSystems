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
    public class IPMakeRepository:IIPMake
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPMakeRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPMakeModel> FilterIPMake()
        {
            throw new NotImplementedException();
        }

        public IPMakeModel FilterIPMake(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPMakeModel iPMakeModel)
        {
            throw new NotImplementedException();
        }
    }
}
