using System;
using Core_Project.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPCompanyProfile
    {
        IEnumerable<IPCompanyProfileModel> FilterIPCompanyProfile();
        IPCompanyProfileModel FilterIPCompanyProfile(int id);
        void Add(IPCompanyProfileModel iPCompanyProfileModel);
    }
}
