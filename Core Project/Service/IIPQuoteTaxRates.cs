using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPQuoteTaxRates
    {
        IEnumerable<IPQuoteTaxRatesModel> FilterIPQuoteTaxRates();
        IPQuoteTaxRatesModel FilterIPQuoteTaxRates(int id);
        void Add(IPQuoteTaxRatesModel iPQuoteTaxRatesModel);
        void Update(IPQuoteTaxRatesModel iPQuoteTaxRatesModel);
        IPQuoteTaxRatesModel FilterIPQuoteTaxRates(IPQuotesModel model);
        IPQuoteTaxRatesModel FilterIPQuoteTaxRates(IPPurchaseModel model);
    }
}
