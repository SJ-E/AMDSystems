using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPaymentMethods
    {
        IEnumerable<IPPaymentMethodsModel> FilterIPPaymentMethods();
        IPPaymentMethodsModel FilterIPPaymentMethods(int id);
        void Add(IPPaymentMethodsModel iPPaymentMethodsModel);
    }
}
