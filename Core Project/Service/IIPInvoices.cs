using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
   public interface IIPInvoices
    {
        IEnumerable<IPQuotesModel> FilterIPInvoices();
        IPQuotesModel FilterIPInvoices(int id);
        int Add(IPInvoicesModel iPInvoicesModel);
        void Update(IPInvoicesModel iPQuotesModel);
        void UpdateStatus(IPInvoicesModel iPQuotesModel);
    }
}
