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
    public class IPItemsLookupRepository:IIPItemsLookup
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPItemsLookupRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPItemsLookupModel> FilterIPItemsLookup()
        {
            throw new NotImplementedException();
        }

        public IPItemsLookupModel FilterIPItemsLookup(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPItemsLookupModel iPItemsLookupModel)
        {
            throw new NotImplementedException();
        }
    }
}
