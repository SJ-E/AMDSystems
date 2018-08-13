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
    public class IPPurchaseRepository :IIPPurchase
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get;
            set;
        }


        public IPPurchaseRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public int Add(IPPurchaseModel iPQuotesModel)
        {
            if (iPQuotesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesModel));
            }

            iPQuotesModel.quote_date_created = DateTime.Now;
            iPQuotesModel.quote_date_modified = DateTime.Now;
            iPQuotesModel.quote_date_expires = DateTime.Now.AddMonths(12);
            iPQuotesModel.quote_url_key = string.IsNullOrEmpty(iPQuotesModel.quote_url_key) ? string.Empty : iPQuotesModel.quote_url_key;
            iPQuotesModel.invoice_group_id = iPQuotesModel.invoice_group_id == 0 ? 1 : iPQuotesModel.invoice_group_id;
            iPQuotesModel.user_id = iPQuotesModel.user_id == 0 ? 1 : iPQuotesModel.user_id;
            ip_quotes ipQuotesDB = Mapper.Map(iPQuotesModel, new ip_quotes());
            AMDSystemsEntities.ip_quotes.Add(ipQuotesDB);
            AMDSystemsEntities.SaveChanges();
            return ipQuotesDB.quote_id;
        }

        public IEnumerable<IPPurchaseModel> FilterIPPurchase()
        {
            //var allIPQuotesDB = AMDSystemsEntities.ip_quotes.Where(e => !(e.is_quote_delete.HasValue && e.is_quote_delete.Value)).Where(e=> e.type==2).Select(c => c).OrderByDescending(e => e.quote_id).ToList();
            //var allIPQuotesModel = new List<IPPurchaseModel>();
            //allIPQuotesDB.ForEach(c => allIPQuotesModel.Add(Mapper.Convert(c,true)));
            var allIPQuotesDB = AMDSystemsEntities.ip_quotes.Join(AMDSystemsEntities.ip_clients, a => a.client_id, b => b.client_id, (a, b) => new { a, b })
                .Join(AMDSystemsEntities.ip_quote_amounts, c => c.a.quote_id, d => d.quote_id, (c, d) => new { c, d })
                .Where(e => !(e.c.a.is_quote_delete.HasValue && e.c.a.is_quote_delete.Value))
                .Where(c => c.c.a.type == 0).Select(c => c)
                .OrderByDescending(e => e.c.a.quote_id).ToList();
            var allIPQuotesModel = new List<IPPurchaseModel>();
            foreach (var item in allIPQuotesDB)
            {
                IPPurchaseModel ip_q_temp = new IPPurchaseModel();
                ip_q_temp.client_id = item.c.a.client_id;
                ip_q_temp.delivery_notes = item.c.a.delivery_notes;
                ip_q_temp.invoice_group_id = item.c.a.invoice_group_id;
                ip_q_temp.notes = item.c.a.notes;
                ip_q_temp.quote_id = item.c.a.quote_id;
                ip_q_temp.user_id = item.c.a.user_id;
                ip_q_temp.quote_status_id = item.c.a.quote_status_id;
                ip_q_temp.quote_date_created = item.c.a.quote_date_created;
                ip_q_temp.quote_date_modified = item.c.a.quote_date_modified;
                ip_q_temp.client_id = item.c.a.client_id;
                ip_q_temp.quote_discount_amount = item.c.a.quote_discount_amount;
                ip_q_temp.client_name = item.c.b.client_name;
                //ip_q_temp.quote_total = item.d.quote_total;
                allIPQuotesModel.Add(ip_q_temp);
            }
            return allIPQuotesModel;
        }

        public IPPurchaseModel FilterIPPurchase(int id)
        {
            var ipQuotesDB = AMDSystemsEntities.ip_quotes.Where(e => !(e.is_quote_delete.HasValue && e.is_quote_delete.Value)).Where(q => q.quote_id == id).Where(c => c.type == 2).FirstOrDefault();
            var ipQuotesModel = Mapper.Convert(ipQuotesDB,true);
            return ipQuotesModel;
        }

        public void DeletePurchase(int quoteId)
        {
            var ipQuotesDB = AMDSystemsEntities.ip_quotes.Where(c => c.quote_id == quoteId).FirstOrDefault();
            if (ipQuotesDB != null)
            {
                ipQuotesDB.is_quote_delete = true;
                ipQuotesDB.quote_date_modified = DateTime.Now;
                AMDSystemsEntities.SaveChanges();
            }
        }

        public void UpdatePurchase(IPPurchaseModel iPQuotesModel)
        {
            var ipQuotesDB = AMDSystemsEntities.ip_quotes.Where(c => c.quote_id == iPQuotesModel.quote_id).FirstOrDefault();
            ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
            ipQuotesDB.quote_date_modified = DateTime.Now;
            ipQuotesDB.is_quote = iPQuotesModel.quote_status_id == 4 ? false : true;
            ipQuotesDB.taxType = iPQuotesModel.taxType;
            AMDSystemsEntities.SaveChanges();
        }
      

      
        public void Update(IPPurchaseModel iPQuotesModel)
        {
            var ipQuotesDB = AMDSystemsEntities.ip_quotes.Where(c => c.quote_id == iPQuotesModel.quote_id).FirstOrDefault();
            ipQuotesDB.quote_date_modified = DateTime.Now;
            ipQuotesDB.payment_method = iPQuotesModel.payment_method;
           
           
            ipQuotesDB.is_quote = iPQuotesModel.quote_status_id == 4 ? false : true;
            AMDSystemsEntities.SaveChanges();
        }




        public void UpdateStatus(IPPurchaseModel iPQuotesModel)
        {
            var ipQuotesDB = AMDSystemsEntities.ip_quotes.Where(c => c.quote_id == iPQuotesModel.quote_id).FirstOrDefault();
            ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
            ipQuotesDB.quote_date_modified = DateTime.Now;
            ipQuotesDB.is_quote = iPQuotesModel.quote_status_id == 4 ? false : true;
            ipQuotesDB.taxType = iPQuotesModel.taxType;
            AMDSystemsEntities.SaveChanges();
        }
    }
}
