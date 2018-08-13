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
    public class IPQuoteAmountsRepository : IIPQuoteAmounts
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }

        public IPQuoteAmountsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }
        public void Add(IPQuoteAmountsModel iPQuoteAmountsModel)
        {
            if (iPQuoteAmountsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteAmountsModel));
            }

            if (iPQuoteAmountsModel.quote_amount_id == 0)
            {
                ip_quote_amounts ipQuoteAmountsDB = Mapper.Map(iPQuoteAmountsModel, new ip_quote_amounts());
                AMDSystemsEntities.ip_quote_amounts.Add(ipQuoteAmountsDB);
                AMDSystemsEntities.SaveChanges();
            }
            else
            {
                this.Update(iPQuoteAmountsModel);
            }
        }

        public IEnumerable<IPQuoteAmountsModel> FilterIPQuoteAmounts()
        {
            var allIPQuoteAmountsDB = AMDSystemsEntities.ip_quote_amounts.Select(qa => qa).ToList();
            var allIPQuoteAmountsModel = new List<IPQuoteAmountsModel>();
            allIPQuoteAmountsDB.ForEach(c => allIPQuoteAmountsModel.Add(Mapper.Convert(c)));
            return allIPQuoteAmountsModel;
        }

        public IPQuoteAmountsModel FilterIPQuoteAmounts(IPQuotesModel model)
        {
            var allIPQuoteAmountsDB = AMDSystemsEntities.ip_quote_amounts.Where(qa => qa.quote_id == model.quote_id).FirstOrDefault();
            if(allIPQuoteAmountsDB == null)
            {
                return new IPQuoteAmountsModel();
            }
            return Mapper.Convert(allIPQuoteAmountsDB);
        }

        public IPQuoteAmountsModel FilterIPPurchaseAmounts(IPPurchaseModel model)
        {
            var allIPQuoteAmountsDB = AMDSystemsEntities.ip_quote_amounts.Where(qa => qa.quote_id == model.quote_id).FirstOrDefault();
            if (allIPQuoteAmountsDB == null)
            {
                return new IPQuoteAmountsModel();
            }
            return Mapper.Convert(allIPQuoteAmountsDB);
        }

       
        public IPQuoteAmountsModel FilterIPQuoteAmounts(int id)
        {
            var ipQuoteAmountsDB = AMDSystemsEntities.ip_quote_amounts.Where(qa=> qa.quote_amount_id == id).FirstOrDefault();
            var iPQuoteAmountsModel = Mapper.Convert(ipQuoteAmountsDB);
            return iPQuoteAmountsModel;
        }

        public void Update(IPQuoteAmountsModel iPQuoteAmountsModel)
        {
            if (iPQuoteAmountsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteAmountsModel));
            }


            var ipQuoteAmountsDB = AMDSystemsEntities.ip_quote_amounts.Where(qa => qa.quote_amount_id == iPQuoteAmountsModel.quote_amount_id).FirstOrDefault();

            if (ipQuoteAmountsDB == null)
            {
                Add(iPQuoteAmountsModel);
            }
            else
            {
                Mapper.Map(iPQuoteAmountsModel, ipQuoteAmountsDB);
                AMDSystemsEntities.SaveChanges();
            }
            

        }
    }
}
