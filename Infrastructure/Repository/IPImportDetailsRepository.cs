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
    public class IPImportDetailsRepository:IIPImportDetails
    {

        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPImportDetailsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPImportDetailsModel> FilterIPImportDetails()
        {
            throw new NotImplementedException();
        }

        public IPImportDetailsModel FilterIPImportDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPImportDetailsModel iPImportDetailsModel)
        {
            throw new NotImplementedException();
        }
    }
}
