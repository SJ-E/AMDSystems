using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPMake
    {
        IEnumerable<IPMakeModel> FilterIPMake();
        IPMakeModel FilterIPMake(int id);
        void Add(IPMakeModel iPMakeModel);
    }
}
