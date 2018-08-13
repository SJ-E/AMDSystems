using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPurchase
    {
        IEnumerable<IPPurchaseModel> FilterIPPurchase();
        IPPurchaseModel FilterIPPurchase(int id);
        int Add(IPPurchaseModel iPQuotesModel);
        void Update(IPPurchaseModel iPQuotesModel);
        void UpdateStatus(IPPurchaseModel iPQuotesModel);
        void UpdatePurchase(IPPurchaseModel iPQuotesModel);
        void DeletePurchase(int quoteId);
    }
}
