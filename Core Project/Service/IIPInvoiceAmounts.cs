using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPInvoiceAmounts
    {
        IEnumerable<IPInvoiceAmountsModel> FilterIPInvoiceAmounts();
        IPInvoiceAmountsModel FilterIPInvoiceAmounts(int id);
        void Add(IPInvoiceAmountsModel iPInvoiceAmountsModel);
    }
}
