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
    public class IPInvoiceItemsRepository:IIPInvoiceItems
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPInvoiceItemsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPInvoiceItemsModel> FilterIPInvoiceItems()
        {
            throw new NotImplementedException();
        }

        public IPInvoiceItemsModel FilterIPInvoiceItems(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPInvoiceItemsModel iPInvoiceItemsModel)
        {
            throw new NotImplementedException();
        }
    }
}
