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
    public class IPInvoiceGroupsRepository:IIPInvoiceGroups
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPInvoiceGroupsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPInvoiceGroupsModel> FilterIPInvoiceGroups()
        {
            throw new NotImplementedException();
        }

        public IPInvoiceGroupsModel FilterIPInvoiceGroups(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPInvoiceGroupsModel iPInvoiceGroupsModel)
        {
            throw new NotImplementedException();
        }
    }
}
