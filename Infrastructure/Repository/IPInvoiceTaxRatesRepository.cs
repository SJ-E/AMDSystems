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
    public class IPInvoiceTaxRatesRepository:IIPInvoiceTaxRates
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPInvoiceTaxRatesRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPInvoiceTaxRatesModel> FilterIPInvoiceTaxRates()
        {
            throw new NotImplementedException();
        }

        public IPInvoiceTaxRatesModel FilterIPInvoiceTaxRates(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPInvoiceTaxRatesModel iPInvoiceTaxRatesModel)
        {
            throw new NotImplementedException();
        }
    }
}
