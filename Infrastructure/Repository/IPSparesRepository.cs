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
    public class IPSparesRepository : IIPSpares
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPSparesRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPSparesModel iPSparesModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPSparesModel> FilterIPSpares()
        {
            throw new NotImplementedException();
        }

        public IPSparesModel FilterIPSpares(int id)
        {
            throw new NotImplementedException();
        }
    }
}
