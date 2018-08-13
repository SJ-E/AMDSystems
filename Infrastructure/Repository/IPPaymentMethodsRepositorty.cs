using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPPaymentMethodsRepositorty : IIPPaymentMethods
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPPaymentMethodsRepositorty()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }
        public void Add(IPPaymentMethodsModel iPPaymentMethodsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPPaymentMethodsModel> FilterIPPaymentMethods()
        {
            throw new NotImplementedException();
        }

        public IPPaymentMethodsModel FilterIPPaymentMethods(int id)
        {
            throw new NotImplementedException();
        }
    }
}
