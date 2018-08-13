using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
   public interface IIPImports
    {
        IEnumerable<IPImportsModel> FilterIPImports();
        IPImportsModel FilterIPImports(int id);
        void Add(IPImportsModel iPImportsModel);
    }
}
