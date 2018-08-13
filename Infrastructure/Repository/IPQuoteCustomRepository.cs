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
    public class IPQuoteCustomRepository : IIPQuoteCustom
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPQuoteCustomRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }
        public void Add(IPQuoteCustomModel iPQuoteCustomModel)
        {
            if (iPQuoteCustomModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteCustomModel));
            }

            ip_quote_custom ipQuoteCustomDB = Mapper.Map(iPQuoteCustomModel, new ip_quote_custom());
            AMDSystemsEntities.ip_quote_custom.Add(ipQuoteCustomDB);
            AMDSystemsEntities.SaveChanges();
        }

        public IEnumerable<IPQuoteCustomModel> FilterIPQuoteCustom()
        {
            var allIPQuoteCustomDB = AMDSystemsEntities.ip_quote_custom.Select(p => p).ToList();
            var allIPQuoteCustomModel = new List<IPQuoteCustomModel>();
            allIPQuoteCustomDB.ForEach(c => allIPQuoteCustomModel.Add(Mapper.Convert(c)));
            return allIPQuoteCustomModel;
        }

        public IPQuoteCustomModel FilterIPQuoteCustom(int id)
        {
            var ipQuoteCustomDB = AMDSystemsEntities.ip_quote_custom.Where(qc => qc.quote_custom_id == id).FirstOrDefault();
            var iPQuoteCustomModel = Mapper.Convert(ipQuoteCustomDB);
            return iPQuoteCustomModel;

        }

        public void Update(IPQuoteCustomModel iPQuoteCustomModel)
        {
            if (iPQuoteCustomModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuoteCustomModel));
            }
            var ipQuoteCustomDB = AMDSystemsEntities.ip_quote_custom.Where(qc => qc.quote_custom_id == iPQuoteCustomModel.quote_custom_id).FirstOrDefault();
            Mapper.Map(iPQuoteCustomModel, ipQuoteCustomDB);
            AMDSystemsEntities.SaveChanges();

        }
    }
}
