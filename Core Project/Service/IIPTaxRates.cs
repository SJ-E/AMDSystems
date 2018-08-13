using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPTaxRates
    {
        IEnumerable<IPTaxRatesModel> FilterIPTaxRates();
        IPTaxRatesModel FilterIPTaxRates(int id);
        void Add(IPTaxRatesModel iPTaxRatesModel);
        void update(IPTaxRatesModel iPTaxRatesModel);
    }
}
