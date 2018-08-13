using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPInvoiceGroups
    {
        IEnumerable<IPInvoiceGroupsModel> FilterIPInvoiceGroups();
        IPInvoiceGroupsModel FilterIPInvoiceGroups(int id);
        void Add(IPInvoiceGroupsModel iPInvoiceGroupsModel);
    }
}
