using System;
using System.Collections.Generic;
using System.Linq;
using Infrastructure.Data;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPCompany:IIPCompany
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPCompany()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPCompanyModel> FilterIPCompany()
        {
            throw new NotImplementedException();
        }

        public IPCompanyModel FilterIPCompany(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPCompanyModel iPCompanyModel)
        {
            throw new NotImplementedException();
        }
    }
}
