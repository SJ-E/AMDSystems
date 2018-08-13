using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPSessions
    {
        IEnumerable<IPSessionsModel> FilterIPSessions();
        IPSessionsModel FilterIPSessions(int id);
        void Add(IPSessionsModel iPSessionsModel);
    }
}
