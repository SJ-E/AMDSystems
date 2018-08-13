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
    public class IPPurchaseCustomRepository : IIPPurchaseCustom
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPPurchaseCustomRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPPurchaseCustomModel iPPurchaseCustomModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPPurchaseCustomModel> FilterIPPurchaseCustom()
        {
            throw new NotImplementedException();
        }

        public IPPurchaseCustomModel FilterIPPurchaseCustom(int id)
        {
            throw new NotImplementedException();
        }
    }
}
