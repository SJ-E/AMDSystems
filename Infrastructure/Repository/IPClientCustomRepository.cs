using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;

namespace Infrastructure.Repository
{
    public class IPClientCustomRepository : IIPClientCustom
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPClientCustomRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPClientCustomModel iPClientsModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPClientCustomModel> FilterIPClientCustom()
        {
            throw new NotImplementedException();
        }

        public IPClientCustomModel FilterIPClientCustom(int id)
        {
            throw new NotImplementedException();
        }
    }
}
