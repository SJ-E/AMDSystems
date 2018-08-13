 using System;
using System.Collections.Generic;
using Core_Project.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPCompany
    {
        IEnumerable<IPCompanyModel> FilterIPCompany();
        IPCompanyModel FilterIPCompany(int id);
        void Add(IPCompanyModel iPCompanyModel);
    }
}
