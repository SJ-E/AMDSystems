using Infrastructure.Data;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPEmailTemplatesRepository:IIPEmailTemplates
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPEmailTemplatesRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPEmailTemplatesModel> FilterIPEmailTemplates()
        {
            throw new NotImplementedException();
        }

        public IPEmailTemplatesModel FilterIPEmailTemplates(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPEmailTemplatesModel iPEmailTemplatesModel)
        {
            throw new NotImplementedException();
        }
    }
}
