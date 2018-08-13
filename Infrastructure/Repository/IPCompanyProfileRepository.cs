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
    public class IPCompanyProfileRepository:IIPCompanyProfile
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPCompanyProfileRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPCompanyProfileModel> FilterIPCompanyProfile()
        {
            throw new NotImplementedException();
        }

        public IPCompanyProfileModel FilterIPCompanyProfile(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPCompanyProfileModel iPCompanyProfileModel)
        {
            throw new NotImplementedException();
        }
    }
}
