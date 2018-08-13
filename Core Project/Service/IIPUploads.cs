using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPUploads
    {
        IEnumerable<IPUploadsModel> FilterIPUploads();
        IPUploadsModel FilterIPUploads(int id);
        void Add(IPUploadsModel iPUploadsModel);
    }
}
