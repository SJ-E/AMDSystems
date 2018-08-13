using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPUploadsRepository : IIPUploads
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPUploadsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPUploadsModel iPUploadsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPUploadsModel> FilterIPUploads()
        {
            throw new NotImplementedException();
        }

        public IPUploadsModel FilterIPUploads(int id)
        {
            throw new NotImplementedException();
        }
    }
}
