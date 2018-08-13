using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPSpares
    {
        IEnumerable<IPSparesModel> FilterIPSpares();
        IPSparesModel FilterIPSpares(int id);
        void Add(IPSparesModel iPSparesModel);
    }
}
