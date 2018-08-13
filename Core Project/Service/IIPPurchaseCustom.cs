
using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPurchaseCustom
    {
        IEnumerable<IPPurchaseCustomModel> FilterIPPurchaseCustom();
        IPPurchaseCustomModel FilterIPPurchaseCustom(int id);
        void Add(IPPurchaseCustomModel iPPurchaseCustomModel);
    }
}
