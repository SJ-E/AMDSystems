using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPayments
    {
        IEnumerable<IPPaymentsModel> FilterIPPayments();
        IPPaymentsModel FilterIPPayments(int id);
        void Add(IPPaymentsModel iPPaymentsModel);
        IPPaymentsModel FilterIPPaymentsByQuoteID(int quoteId);
        void Update(IPPaymentsModel paymentsModel);
    }
}
