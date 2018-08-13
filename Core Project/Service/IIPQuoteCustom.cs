using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPQuoteCustom
    {
        IEnumerable<IPQuoteCustomModel> FilterIPQuoteCustom();
        IPQuoteCustomModel FilterIPQuoteCustom(int id);
        void Add(IPQuoteCustomModel iPQuoteCustomModel);
        void Update(IPQuoteCustomModel iPQuoteCustomModel);
    }
}
