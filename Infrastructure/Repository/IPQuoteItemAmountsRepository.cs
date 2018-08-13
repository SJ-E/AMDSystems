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
    public class IPQuoteItemAmountsRepository : IIPQuoteItemAmounts
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }

        public IPQuoteItemAmountsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPQuoteItemAmountsModel iPQuoteItemAmountsModel)
        {
            if (iPQuoteItemAmountsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteItemAmountsModel));
            }

            ip_quote_item_amounts ipQuoteItemAmountsDB = Mapper.Map(iPQuoteItemAmountsModel, new ip_quote_item_amounts());
            AMDSystemsEntities.ip_quote_item_amounts.Add(ipQuoteItemAmountsDB);
            AMDSystemsEntities.SaveChanges();
        }

        public IEnumerable<IPQuoteItemAmountsModel> FilterIPQuoteItemAmounts()
        {
            var allipQuoteItemAmountsDB = AMDSystemsEntities.ip_quote_item_amounts.Select(qia => qia).ToList();
            var alliPQuoteItemAmountsModel = new List<IPQuoteItemAmountsModel>();
            allipQuoteItemAmountsDB.ForEach(c => alliPQuoteItemAmountsModel.Add(Mapper.Convert(c)));
            return alliPQuoteItemAmountsModel;

        }

        public IPQuoteItemAmountsModel FilterIPQuoteItemAmounts(int id)
        {
            var ipQuoteItemAmountsDB = AMDSystemsEntities.ip_quote_item_amounts.Where(qia => qia.item_amount_id == id).FirstOrDefault();
            var iPQuoteItemAmountsModel = Mapper.Convert(ipQuoteItemAmountsDB);
            return iPQuoteItemAmountsModel;
        }

        public void Update(IPQuoteItemAmountsModel iPQuoteItemAmountsModel)
        {
            if (iPQuoteItemAmountsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteItemAmountsModel));
            }
            var ipQuoteItemAmountsDB = AMDSystemsEntities.ip_quote_item_amounts.Where(qia =>qia.item_amount_id == iPQuoteItemAmountsModel.item_amount_id).FirstOrDefault();
            Mapper.Map(iPQuoteItemAmountsModel, ipQuoteItemAmountsDB);
            AMDSystemsEntities.SaveChanges();

        }
    }
}
