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
    public class IPMerchantResponsesRepository:IIPMerchantResponses
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPMerchantResponsesRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPMerchantResponsesModel> FilterIPMerchantResponses()
        {
            throw new NotImplementedException();
        }

        public IPMerchantResponsesModel FilterIPMerchantResponses(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPMerchantResponsesModel iPMerchantResponsesModel)
        {
            throw new NotImplementedException();
        }
    }
}
