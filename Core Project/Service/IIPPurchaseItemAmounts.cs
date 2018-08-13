using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPurchaseItemAmounts
    {
        IEnumerable<IPPurchaseItemAmountsModel> FilterIPPurchaseItemAmounts();
        IPPurchaseItemAmountsModel FilterIPPurchaseItemAmounts(int id);
        void Add(IPPurchaseItemAmountsModel iPPurchaseItemAmountsModel);
    }
}
