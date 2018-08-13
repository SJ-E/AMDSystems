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
    public class IPUserCustomRepository : IIPUserCustom
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }

        public IPUserCustomRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public void Add(IPUserCustomModel iPUserCustomModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPUserCustomModel> FilterIPUserCustom()
        {
            throw new NotImplementedException();
        }

        public IPUserCustomModel FilterIPUserCustom(int id)
        {
            throw new NotImplementedException();
        }
    }
}
