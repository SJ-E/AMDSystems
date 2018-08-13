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
    public class IPPaymentsRepository : IIPPayments
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPPaymentsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPPaymentsModel iPPaymentsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPPaymentsModel> FilterIPPayments()
        {
            var paymentsDB = AMDSystemsEntities.ip_payments.Select(e => Mapper.Map(e));
            return paymentsDB;
        }

        public IPPaymentsModel FilterIPPayments(int id)
        {
            throw new NotImplementedException();
        }

        public IPPaymentsModel FilterIPPaymentsByQuoteID(int quoteId)
        {
            var paymentsDB = AMDSystemsEntities.ip_payments.Where(qi => qi.quote_id == quoteId).FirstOrDefault();
            if (paymentsDB != null)
            {
                return Mapper.Map(paymentsDB);
            }
            else
            {
                return new IPPaymentsModel();
            }
        }

        public void Update(IPPaymentsModel paymentsModel)
        {
                var paymentsDB = AMDSystemsEntities.ip_payments.Where(qi => qi.quote_id == paymentsModel.quote_id).FirstOrDefault();
            if (paymentsDB == null)
            {
                paymentsDB = new ip_payments();
                paymentsModel.payment_date = DateTime.Now;
                Mapper.Map(paymentsModel, paymentsDB);
                AMDSystemsEntities.ip_payments.Add(paymentsDB);
            }
            else
            {
                Mapper.Map(paymentsModel, paymentsDB);
            }
            AMDSystemsEntities.SaveChanges();
        }
    }
}
