using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPInvoicesRecurring
    {
        IEnumerable<IPInvoicesRecurringModel> FilterIPInvoicesRecurring();
        IPInvoicesRecurringModel FilterIPInvoicesRecurring(int id);
        void Add(IPInvoicesRecurringModel iPInvoicesRecurringModel);
    }
}
