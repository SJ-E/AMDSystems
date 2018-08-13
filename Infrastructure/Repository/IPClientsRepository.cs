using Core_Project.Model;
using Core_Project.Service;
using System;
using Infrastructure.Data;
using Infrastructure.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPClientsRepository : IIPClients
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }

        public IPClientsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPClientsModel iPClientsModel)
        {
            if (iPClientsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPClientsModel));
            }

            iPClientsModel.Client_Date_Created = DateTime.Now;
            iPClientsModel.Client_Date_Modified = DateTime.Now;
            ip_clients ipClientsDB = Mapper.Map(iPClientsModel, new ip_clients());
            AMDSystemsEntities.ip_clients.Add(ipClientsDB);
            AMDSystemsEntities.SaveChanges();
        }

        public void Update(IPClientsModel ipClientsModel)
        {
            if (ipClientsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPClientsModel));
            }

            var ipClientsDB = AMDSystemsEntities.ip_clients.Where(c => c.client_id == ipClientsModel.Client_ID).FirstOrDefault();

           //ipClientsDB = Mapper.Map(iPClientsModel, ipClientsDB);
            ipClientsDB.client_active = ipClientsModel.Client_Active == null ? 0 : ipClientsModel.Client_Active == true ? 1 : 0;
            ipClientsDB.client_address_1 = ipClientsModel.Client_Address_1;
            ipClientsDB.client_address_2 = ipClientsModel.Client_Address_2;
            ipClientsDB.client_city = ipClientsModel.Client_City;
            ipClientsDB.client_country = ipClientsModel.Client_Country;
            ipClientsDB.client_date_created = System.DateTime.Now;
            ipClientsDB.client_date_modified = System.DateTime.Now;
            ipClientsDB.client_email = ipClientsModel.Client_Email;
            ipClientsDB.client_fax = ipClientsModel.Client_Fax;
            ipClientsDB.client_id = ipClientsModel.Client_ID;
            ipClientsDB.client_mobile = ipClientsModel.Client_Mobile;
            ipClientsDB.client_name = ipClientsModel.Client_Name;
            ipClientsDB.client_phone = ipClientsModel.Client_Phone;
            ipClientsDB.client_state = ipClientsModel.Client_State;
            ipClientsDB.client_tax_code = ipClientsModel.Client_Tax_Code;
            ipClientsDB.client_vat_id = ipClientsModel.Client_VAT_ID;
            ipClientsDB.client_web = ipClientsModel.Client_Web;
            ipClientsDB.client_zip = ipClientsModel.Client_Zip;
            ipClientsDB.clientType = ipClientsModel.clientType;
            AMDSystemsEntities.Entry(ipClientsDB).State = System.Data.Entity.EntityState.Modified;
            AMDSystemsEntities.SaveChanges();
        }

        public IEnumerable<IPClientsModel> FilterIPClients(long type=0)
        {
            var allIPClientsDB = AMDSystemsEntities.ip_clients.Select(c => c).Where(e => e.clientType == type || (type == 0 && !e.clientType.HasValue)).Where(e => !(e.isdelete.HasValue && e.isdelete.Value)).OrderByDescending(e => e.client_id).OrderByDescending(e => e.client_id).ToList();
            var allIPClientsModel = new List<IPClientsModel>();
            allIPClientsDB.ForEach(c => allIPClientsModel.Add(Mapper.Convert(c)));
            return allIPClientsModel;
        }
        public IEnumerable<IPClientsModel> FilterIPSupplier(long type = 0)
        {
            var allIPClientsDB = AMDSystemsEntities.ip_clients.Select(c => c).Where(e => e.clientType == type || (type == 0 && !e.clientType.HasValue)).Where(e => !(e.isdelete.HasValue && e.isdelete.Value)).OrderByDescending(e => e.client_id).OrderByDescending(e => e.client_id).ToList();
            var allIPClientsModel = new List<IPClientsModel>();
            allIPClientsDB.ForEach(c => allIPClientsModel.Add(Mapper.Convert(c)));
            return allIPClientsModel;
        }

        public IPClientsModel FilterIPClients(int id, int type = 0)
        {
            var ipClientsDB = AMDSystemsEntities.ip_clients.Where(e => e.clientType == type || (type == 0 && !e.clientType.HasValue)).Where(e => !(e.isdelete.HasValue && e.isdelete.Value)).Where(c => c.client_id == id).Select(c => c).FirstOrDefault();
            var ipClientsModel = Mapper.Convert(ipClientsDB);
            return ipClientsModel;        
        }

        public IEnumerable<IPClientsModel> FilterIPClients(string keyword, int type = 0)
        {
            var allIPClientsDB = AMDSystemsEntities.ip_clients.Where(e => e.clientType == type || (type == 0 && !e.clientType.HasValue)).Where(e => !(e.isdelete.HasValue && e.isdelete.Value)).Select(c => c)
                .Where(e => e.client_name.Contains(keyword) || e.client_email.Contains(keyword) || e.client_phone.Contains(keyword))
                .OrderByDescending(e => e.client_id).OrderByDescending(e => e.client_id).ToList();
            var allIPClientsModel = new List<IPClientsModel>();
            allIPClientsDB.ForEach(c => allIPClientsModel.Add(Mapper.Convert(c)));
            return allIPClientsModel;
        }


        public void DeleteClient(int clientId)
        {
            var ipClinetDB = AMDSystemsEntities.ip_clients.Where(c => c.client_id == clientId).FirstOrDefault();
            if (ipClinetDB != null)
            {
                ipClinetDB.isdelete = true;
                ipClinetDB.client_date_modified = DateTime.Now;
                AMDSystemsEntities.SaveChanges();
            }
        }
    }
}
