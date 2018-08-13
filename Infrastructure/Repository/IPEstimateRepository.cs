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
    public class IPEstimateRepository:IIPEstimate
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPEstimateRepository()
        {


            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPEstimateModel> FilterIPEstimate()
        {
            throw new NotImplementedException();
        }

        public IPEstimateModel FilterIPEstimate(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPEstimateModel iPEstimateModel)
        {
            throw new NotImplementedException();
        }
    }
}
