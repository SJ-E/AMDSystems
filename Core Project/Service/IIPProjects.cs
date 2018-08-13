using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPProjects
    {
        IEnumerable<IPProjectsModel> FilterIPProjects();
        IPProjectsModel FilterIPProjects(int id);
        void Add(IPProjectsModel iPProjectsModel);
    }
}
