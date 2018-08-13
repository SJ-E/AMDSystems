using Infrastructure.Data;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPImportsRepository:IIPImports
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPImportsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPImportsModel> FilterIPImports()
        {
            throw new NotImplementedException();
        }

        public IPImportsModel FilterIPImports(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPImportsModel iPImportsModel)
        {
            throw new NotImplementedException();
        }
    }
}
