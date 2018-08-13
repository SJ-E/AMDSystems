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
    public class IPCustomFieldsRepository:IIPCustomFields
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPCustomFieldsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPCustomFieldsModel> FilterIPCustomFields()
        {
            throw new NotImplementedException();
        }

        public IPCustomFieldsModel FilterIPCustomFields(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPCustomFieldsModel iPCustomFieldsModel)
        {
            throw new NotImplementedException();
        }
    }
}
