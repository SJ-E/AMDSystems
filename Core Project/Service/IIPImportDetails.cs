using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPImportDetails
    {
        IEnumerable<IPImportDetailsModel> FilterIPImportDetails();
        IPImportDetailsModel FilterIPImportDetails(int id);
        void Add(IPImportDetailsModel iPImportDetailsModel);
    }
}
