using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPPaymentCustom
    {
        IEnumerable<IPPaymentCustomModel> FilterIPPaymentCustom();
        IPPaymentCustomModel FilterIPPaymentCustom(int id);
        void Add(IPPaymentCustomModel iPPaymentCustomModel);
    }
}
