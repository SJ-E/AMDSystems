using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPVersions
    {
        IEnumerable<IPVersionsModel> FilterIPVersions();
        IPVersionsModel FilterIPVersions(int id);
        void Add(IPVersionsModel iPVersionsModel);
    }
}
