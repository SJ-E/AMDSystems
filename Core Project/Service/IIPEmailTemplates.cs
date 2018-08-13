using Core_Project.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
   public interface IIPEmailTemplates
    {
        IEnumerable<IPEmailTemplatesModel> FilterIPEmailTemplates();
        IPEmailTemplatesModel FilterIPEmailTemplates(int id);
        void Add(IPEmailTemplatesModel iPEmailTemplatesModel);
    }
}
