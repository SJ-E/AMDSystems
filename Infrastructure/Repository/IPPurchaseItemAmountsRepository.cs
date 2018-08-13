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
    public class IPPurchaseItemAmountsRepository : IIPPurchaseItemAmounts
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPPurchaseItemAmountsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPPurchaseItemAmountsModel iPPurchaseItemAmountsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPPurchaseItemAmountsModel> FilterIPPurchaseItemAmounts()
        {
            throw new NotImplementedException();
        }

        public IPPurchaseItemAmountsModel FilterIPPurchaseItemAmounts(int id)
        {
            throw new NotImplementedException();
        }
    }
}
