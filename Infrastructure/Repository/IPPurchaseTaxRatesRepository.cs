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
    public class IPPurchaseTaxRatesRepository : IIPPurchaseTaxRates
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPPurchaseTaxRatesRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPPurchaseTaxRatesModel iPPurchaseTaxRatesModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPPurchaseTaxRatesModel> FilterIPPurchaseTaxRates()
        {
            throw new NotImplementedException();
        }

        public IPPurchaseTaxRatesModel FilterIPPurchaseTaxRates(int id)
        {
            throw new NotImplementedException();
        }
    }
}
