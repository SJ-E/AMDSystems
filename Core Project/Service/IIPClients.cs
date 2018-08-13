using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_Project.Model;

namespace Core_Project.Service
{
     public interface IIPClients
    {
         IEnumerable<IPClientsModel> FilterIPClients(long type = 0);
        IPClientsModel FilterIPClients(int id, int type = 0);
        void Add(IPClientsModel iPClientsModel);
        void Update(IPClientsModel iPClientsModel);
        void DeleteClient(int clientId);
        IEnumerable<IPClientsModel> FilterIPClients(string keyword, int type = 0);
        IEnumerable<IPClientsModel> FilterIPSupplier(long type = 0);
    }
}
