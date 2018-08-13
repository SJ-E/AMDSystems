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
    public class IPInvoiceAmountsRepository:IIPInvoiceAmounts
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPInvoiceAmountsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPInvoiceAmountsModel> FilterIPInvoiceAmounts()
        {
            throw new NotImplementedException();
        }

        public IPInvoiceAmountsModel FilterIPInvoiceAmounts(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPInvoiceAmountsModel iPInvoiceAmountsModel)
        {
            throw new NotImplementedException();
        }
    }
}
