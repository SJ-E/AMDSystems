using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPItemsLookup
    {
        IEnumerable<IPItemsLookupModel> FilterIPItemsLookup();
        IPItemsLookupModel FilterIPItemsLookup(int id);
        void Add(IPItemsLookupModel iPItemsLookupModel);
    }
}
