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
    public class IPPaymentCustomRepository : IIPPaymentCustom
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPPaymentCustomRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPPaymentCustomModel> FilterIPPaymentCustom()
        {
            throw new NotImplementedException();
        }

        public IPPaymentCustomModel FilterIPPaymentCustom(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPPaymentCustomModel iPPaymentCustomModel)
        {
            throw new NotImplementedException();
        }
    }
}
