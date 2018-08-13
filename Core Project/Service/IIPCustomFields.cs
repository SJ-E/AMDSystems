using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPCustomFields
    {
        IEnumerable<IPCustomFieldsModel> FilterIPCustomFields();
        IPCustomFieldsModel FilterIPCustomFields(int id);
        void Add(IPCustomFieldsModel iPCustomFieldsModel);
    }
}
