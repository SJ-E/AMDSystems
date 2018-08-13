using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPMerchantResponses
    {
        IEnumerable<IPMerchantResponsesModel> FilterIPMerchantResponses();
        IPMerchantResponsesModel FilterIPMerchantResponses(int id);
        void Add(IPMerchantResponsesModel iPMerchantResponsesModel);
    }
}
