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
    public class IPUserClientsRepository : IIPUserClients
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPUserClientsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPUserClientsModel iPUserClientsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPUserClientsModel> FilterIPUserClients()
        {
            throw new NotImplementedException();
        }

        public IPUserClientsModel FilterIPUserClients(int id)
        {
            throw new NotImplementedException();
        }
    }
}
