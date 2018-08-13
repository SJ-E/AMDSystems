using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPTaxRatesRepository : IIPTaxRates
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }

        public IPTaxRatesRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPTaxRatesModel iPTaxRatesModel)
        {
            if (iPTaxRatesModel == null)
            {
                return;
            }

            ip_tax_rates ipClientsDB = Mapper.Map(iPTaxRatesModel, new ip_tax_rates());
            AMDSystemsEntities.ip_tax_rates.Add(ipClientsDB);
            AMDSystemsEntities.SaveChanges();
        }



        public void update(IPTaxRatesModel iPTaxRatesModel)
        {
            if (iPTaxRatesModel == null)
            {
                return;
            }

            var taxRates = AMDSystemsEntities.ip_tax_rates.Where(e => e.tax_rate_id == iPTaxRatesModel.tax_rate_id).Select(qtr => qtr).FirstOrDefault();
            ip_tax_rates ipClientsDB = Mapper.Map(iPTaxRatesModel, taxRates);
            AMDSystemsEntities.ip_tax_rates.Add(ipClientsDB);
            AMDSystemsEntities.SaveChanges();
        }

        public IEnumerable<IPTaxRatesModel> FilterIPTaxRates()
        {
            var allIPQuoteTaxRatesDB = AMDSystemsEntities.ip_tax_rates.Select(qtr => qtr).ToList();
            var allIPQuoteTaxRatesModel = new List<IPTaxRatesModel>();
            allIPQuoteTaxRatesDB.ForEach(qtr => allIPQuoteTaxRatesModel.Add(Mapper.Convert(qtr)));
            return allIPQuoteTaxRatesModel;
        }

        public IPTaxRatesModel FilterIPTaxRates(int id)
        {
            var allIPQuoteTaxRatesDB = AMDSystemsEntities.ip_tax_rates.Where(e => e.tax_rate_id == id).Select(qtr => qtr).FirstOrDefault();
            if (allIPQuoteTaxRatesDB != null)
            {
                var allIPQuoteTaxRatesModel = Mapper.Convert(allIPQuoteTaxRatesDB);
                return allIPQuoteTaxRatesModel;
            }
            else
            {
                return null;
            }
        }
    }
}
