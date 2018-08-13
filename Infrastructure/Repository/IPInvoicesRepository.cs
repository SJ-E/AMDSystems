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
    public class IPInvoicesRepository:IIPInvoices
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPInvoicesRepository()
        {

            AMDSystemsEntities = new AMDSystemsEntities();

        }

        

        public int Add(IPInvoicesModel iPQuotesModel)
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

        public IEnumerable<IPQuotesModel> FilterIPInvoices()
        {
            var allIPQuotesDB = AMDSystemsEntities.ip_quotes.Where(e=> !(e.is_quote_delete.HasValue && e.is_quote_delete.Value)).Where(c =>c.type==1).Select(c => c).ToList();
            //var allIPQuotesDB = AMDSystemsEntities.ip_quotes.Join(AMDSystemsEntities.ip_clients, a => a.client_id, b => b.client_id, (a, b) => new { a, b })
            //    .Where(e => !(e.a.is_quote_delete.HasValue && e.a.is_quote_delete.Value))
            //    .Where(c => c.a.type == 1).Select(c => c)
            //    .OrderByDescending(e => e.a.quote_id).ToList();
           
            var allIPQuotesModel = new List<IPQuotesModel>();

           
           allIPQuotesDB.ForEach(c => allIPQuotesModel.Add(Mapper.Convert(c)));

            //List<IPInvoicesModel> iPInvoiceMOdel = Mapper.Map(allIPQuotesModel, new List<IPInvoicesModel>());
            //foreach (var item in allIPQuotesDB)
            //{
            //    IPQuotesModel ip_q_temp = new IPQuotesModel();
            //    ip_q_temp.client_id = item.a.client_id;
            //    ip_q_temp.delivery_notes = item.a.delivery_notes;
            //    ip_q_temp.invoice_group_id = item.a.invoice_group_id;
            //    ip_q_temp.notes = item.a.notes;

            //    ip_q_temp.quote_id = item.a.quote_id;
            //    ip_q_temp.user_id = item.a.user_id;
            //    ip_q_temp.quote_status_id = item.a.quote_status_id;
            //    ip_q_temp.quote_date_created = item.a.quote_date_created;
            //    ip_q_temp.quote_date_modified = item.a.quote_date_modified;

            //    ip_q_temp.client_id = item.a.client_id;
            //    ip_q_temp.client_name = item.b.client_name;
            //    allIPQuotesModel.Add(ip_q_temp);
            //}
            return allIPQuotesModel;
        }

        public IPQuotesModel FilterIPInvoices(int id)
        {
            var ipQuotesDB = AMDSystemsEntities.ip_quotes.Where(e => !(e.is_quote_delete.HasValue && e.is_quote_delete.Value)).Where(q => q.quote_id == id).Where(c => c.type == 1).FirstOrDefault();
            if (ipQuotesDB != null)
            {
                var ipQuotesModel = Mapper.Convert(ipQuotesDB);
                return ipQuotesModel;
            }
            else
            {
                return null;
            }
        }

        public void UpdateStatus(IPInvoicesModel iPInvoiceModel)
        {
            IPQuotesModel iPQuotesModel = Mapper.Map(iPInvoiceModel, new IPQuotesModel());

            var ipQuotesDB = AMDSystemsEntities.ip_quotes.Where(c => c.quote_id == iPQuotesModel.quote_id).FirstOrDefault();
            ipQuotesDB.quote_status_id = iPQuotesModel.quote_status_id;
            ipQuotesDB.quote_date_modified = DateTime.Now;
            ipQuotesDB.is_quote = iPQuotesModel.quote_status_id == 4 ? false : true;
            ipQuotesDB.taxType = iPInvoiceModel.taxType;
            AMDSystemsEntities.SaveChanges();
        }


        public void Update(IPInvoicesModel iPInvoiceModel)
        {
            if (iPInvoiceModel == null)
            {
                //throw new ArgumentNullException(nameof(iPQuotesModel));
            }
            IPQuotesModel iPQuotesModel = Mapper.Map(iPInvoiceModel, new IPQuotesModel());
            iPQuotesModel.quote_date_modified = DateTime.Now;
            var ipQuotesDB = AMDSystemsEntities.ip_quotes.Where(c => c.client_id == iPQuotesModel.quote_id).FirstOrDefault();
            ipQuotesDB = Mapper.Map(iPQuotesModel, ipQuotesDB);
            AMDSystemsEntities.ip_quotes.Add(ipQuotesDB);
            AMDSystemsEntities.SaveChanges();
        }
    }
}
