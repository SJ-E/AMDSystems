using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPQuoteAmounts
    {
        IEnumerable<IPQuoteAmountsModel> FilterIPQuoteAmounts();
        IPQuoteAmountsModel FilterIPQuoteAmounts(int id);
        void Add(IPQuoteAmountsModel iPQuoteAmountsModel);
        void Update(IPQuoteAmountsModel iPQuoteAmountsModel);
        IPQuoteAmountsModel FilterIPQuoteAmounts(IPQuotesModel model);
        IPQuoteAmountsModel FilterIPPurchaseAmounts(IPPurchaseModel model);
    }
}
