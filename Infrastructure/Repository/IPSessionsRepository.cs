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
    public class IPSessionsRepository : IIPSessions
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPSessionsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPSessionsModel iPSessionsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPSessionsModel> FilterIPSessions()
        {
            throw new NotImplementedException();
        }

        public IPSessionsModel FilterIPSessions(int id)
        {
            throw new NotImplementedException();
        }
    }
}
