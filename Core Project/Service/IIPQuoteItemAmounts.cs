using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPQuoteItemAmounts
    {
        IEnumerable<IPQuoteItemAmountsModel> FilterIPQuoteItemAmounts();
        IPQuoteItemAmountsModel FilterIPQuoteItemAmounts(int id);
        void Add(IPQuoteItemAmountsModel iPQuoteItemAmountsModel);
        void Update(IPQuoteItemAmountsModel iPQuoteItemAmountsModel);
    }
}
