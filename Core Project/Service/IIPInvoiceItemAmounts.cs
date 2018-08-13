using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
     public interface IIPInvoiceItemAmounts
    {
        IEnumerable<IPInvoiceItemAmountsModel> FilterIPInvoiceItemAmounts();
        IPInvoiceItemAmountsModel FilterIPInvoiceItemAmounts(int id);
        void Add(IPInvoiceItemAmountsModel iPInvoiceItemAmountsModel);
    }
}
