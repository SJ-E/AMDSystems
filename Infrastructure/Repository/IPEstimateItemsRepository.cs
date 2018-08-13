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
    public class IPEstimateItemsRepository:IIPEstimateItems
    {
        public AMDSystemsEntities aMDSystemsEntities
        {
            get; set;
        }
        public IPEstimateItemsRepository()
        {
            aMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPEstimateItemsModel> FilterIPEstimateItems()
        {
            throw new NotImplementedException();
        }

        public IPEstimateItemsModel FilterIPEstimateItems(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(IPEstimateItemsModel iPEstimateItemsModel)
        {
            throw new NotImplementedException();
        }
    }
}
