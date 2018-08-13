using Core_Project.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
   public interface IIPInvoiceItems
    {
        IEnumerable<IPInvoiceItemsModel> FilterIPInvoiceItems();
        IPInvoiceItemsModel FilterIPInvoiceItems(int id);
        void Add(IPInvoiceItemsModel iPInvoiceItemsModel);
    }
}
