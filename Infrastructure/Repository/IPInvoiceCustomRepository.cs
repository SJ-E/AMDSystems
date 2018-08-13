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
    public class IPInvoiceCustomRepository:IIPInvoiceCustom
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPInvoiceCustomRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPInvoiceCustomModel> FilterIPInvoiceCustom()
        {
            throw new NotImplementedException();
        }

        public IPInvoiceCustomModel FilterIPInvoiceCustom(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPInvoiceCustomModel iPInvoiceCustomModel)
        {
            throw new NotImplementedException();
        }
    }
}
