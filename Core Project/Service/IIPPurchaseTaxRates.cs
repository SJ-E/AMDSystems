using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPurchaseTaxRates
    {
        IEnumerable<IPPurchaseTaxRatesModel> FilterIPPurchaseTaxRates();
        IPPurchaseTaxRatesModel FilterIPPurchaseTaxRates(int id);
        void Add(IPPurchaseTaxRatesModel iPPurchaseTaxRatesModel);
    }
}
