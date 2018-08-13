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
    public class IPQuoteTaxRatesRepository : IIPQuoteTaxRates
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }

        public IPQuoteTaxRatesRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPQuoteTaxRatesModel iPQuoteTaxRatesModel)
        {
            if (iPQuoteTaxRatesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteTaxRatesModel));
            }
            if (iPQuoteTaxRatesModel.tax_rate_id == 0)
            {
                ip_quote_tax_rates ipQuoteTaxRatedDB = Mapper.Map(iPQuoteTaxRatesModel, new ip_quote_tax_rates());
                AMDSystemsEntities.ip_quote_tax_rates.Add(ipQuoteTaxRatedDB);
                AMDSystemsEntities.SaveChanges();
            }
            else
            {
                this.Update(iPQuoteTaxRatesModel);
            }
        }

        public IEnumerable<IPQuoteTaxRatesModel> FilterIPQuoteTaxRates()
        {
            var allIPQuoteTaxRatesDB = AMDSystemsEntities.ip_quote_tax_rates.Select(qtr => qtr).ToList();
            var allIPQuoteTaxRatesModel = new List<IPQuoteTaxRatesModel>();
            allIPQuoteTaxRatesDB.ForEach(qtr => allIPQuoteTaxRatesModel.Add(Mapper.Convert(qtr)));
            return allIPQuoteTaxRatesModel;
        }

        public IPQuoteTaxRatesModel FilterIPQuoteTaxRates(int id)
        {
            var ipQuoteTaxRatesDB = AMDSystemsEntities.ip_quote_tax_rates.Select(qtr => qtr).FirstOrDefault();
            var ipQuoteTaxRatesModel = Mapper.Convert(ipQuoteTaxRatesDB);
            return ipQuoteTaxRatesModel;
        }

        public IPQuoteTaxRatesModel FilterIPQuoteTaxRates(IPQuotesModel model)
        {
            var ipQuoteTaxRatesDB = AMDSystemsEntities.ip_quote_tax_rates.Where(qtr => qtr.quote_id == model.quote_id).FirstOrDefault();
            if (ipQuoteTaxRatesDB == null)
            {
                return new IPQuoteTaxRatesModel();
            }
            var ipQuoteTaxRatesModel = Mapper.Convert(ipQuoteTaxRatesDB);
            return ipQuoteTaxRatesModel;
        }

        public IPQuoteTaxRatesModel FilterIPQuoteTaxRates(IPPurchaseModel model)
        {
            var ipQuoteTaxRatesDB = AMDSystemsEntities.ip_quote_tax_rates.Where(qtr => qtr.quote_id == model.quote_id).FirstOrDefault();
            if (ipQuoteTaxRatesDB == null)
            {
                return new IPQuoteTaxRatesModel();
            }
            var ipQuoteTaxRatesModel = Mapper.Convert(ipQuoteTaxRatesDB);
            return ipQuoteTaxRatesModel;
        }

        public void Update(IPQuoteTaxRatesModel iPQuoteTaxRatesModel)
        {
            if (iPQuoteTaxRatesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteTaxRatesModel));
            }

            var ipQuoteTaxRatesDB = AMDSystemsEntities.ip_quote_tax_rates.Where(qtr => qtr.quote_tax_rate_id == iPQuoteTaxRatesModel.quote_tax_rate_id).FirstOrDefault();
            ipQuoteTaxRatesDB = Mapper.Map(iPQuoteTaxRatesModel, ipQuoteTaxRatesDB);

            AMDSystemsEntities.SaveChanges();
        }
    }
}
