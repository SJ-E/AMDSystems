using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPInvoiceTaxRates
    {
        IEnumerable<IPInvoiceTaxRatesModel> FilterIPInvoiceTaxRates();
        IPInvoiceTaxRatesModel FilterIPInvoiceTaxRates(int id);
        void Add(IPInvoiceTaxRatesModel iPInvoiceTaxRatesModel);
    }
}
