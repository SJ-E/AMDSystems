using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPClientCustom
    {
        IEnumerable<IPClientCustomModel> FilterIPClientCustom();
        IPClientCustomModel FilterIPClientCustom(int id);
        void Add(IPClientCustomModel iPClientCustomModel);
    }
}
