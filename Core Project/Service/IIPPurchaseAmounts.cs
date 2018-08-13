
using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPurchaseAmounts
    {
        IEnumerable<IPPurchaseAmountsModel> FilterIPPurchaseAmounts();
        IPPurchaseAmountsModel FilterIPPurchaseAmounts(int id);
        void Add(IPPurchaseAmountsModel iPPurchaseAmountsModel);
    }
}
