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
    public class IPModelRepository:IIPModel
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPModelRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPModelModel> FilterIPModel()
        {
            throw new NotImplementedException();
        }

        public IPModelModel FilterIPModel(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPModelModel iPModelModel)
        {
            throw new NotImplementedException();
        }
    }
}
