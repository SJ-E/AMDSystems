using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPurchaseItems
    {
        IEnumerable<IPPurchaseItemsModel> FilterIPPurchaseItems();
        IPPurchaseItemsModel FilterIPPurchaseItems(int id);
        void Add(IPPurchaseItemsModel iPPurchaseItemsModel);
    }
}
