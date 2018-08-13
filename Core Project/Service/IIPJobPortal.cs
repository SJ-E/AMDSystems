using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPJobPortal
    {
        IEnumerable<IPJobPortalModel> FilterIPJobPortal();
        IPJobPortalModel FilterIPJobPortal(int id);
        void Add(IPJobPortalModel iPJobPortalModel);
    }
}
