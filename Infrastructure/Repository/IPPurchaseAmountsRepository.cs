using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPPurchaseAmountsRepository 
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }

        public IPPurchaseAmountsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPPurchaseModel iPPurchaseModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPPurchaseModel> FilterIPPurchase()
        {
            throw new NotImplementedException();
        }

        public IPPurchaseModel FilterIPPurchase(int id)
        {
            throw new NotImplementedException();
        }
    }
}
