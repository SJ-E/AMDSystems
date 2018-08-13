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
    public class IPInvoiceItemAmountsRepository:IIPInvoiceItemAmounts
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPInvoiceItemAmountsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPInvoiceItemAmountsModel> FilterIPInvoiceItemAmounts()
        {
            throw new NotImplementedException();
        }

        public IPInvoiceItemAmountsModel FilterIPInvoiceItemAmounts(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPInvoiceItemAmountsModel iPInvoiceItemAmountsModel)
        {
            throw new NotImplementedException();
        }
    }
}
