using Infrastructure.Data;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPInvoicesRecurringRepository:IIPInvoicesRecurring
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPInvoicesRecurringRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPInvoicesRecurringModel> FilterIPInvoicesRecurring()
        {
            throw new NotImplementedException();
        }

        public IPInvoicesRecurringModel FilterIPInvoicesRecurring(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPInvoicesRecurringModel iPInvoicesRecurringModel)
        {
            throw new NotImplementedException();
        }
    }
}
