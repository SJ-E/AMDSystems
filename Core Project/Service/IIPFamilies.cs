using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPFamilies
    {
        IEnumerable<IPFamiliesModel> FilterIPFamilies();
        IPFamiliesModel FilterIPFamilies(int id);
        void Add(IPFamiliesModel iPFamiliesModel);
        void Update(IPFamiliesModel iPFamiliesModel);
    }
}
