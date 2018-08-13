using System;
using Core_Project.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPEstimateItems
    {
        IEnumerable<IPEstimateItemsModel> FilterIPEstimateItems();
        IPEstimateItemsModel FilterIPEstimateItems(int id);
        void Add(IPEstimateItemsModel iPEstimateItemsModel);
    }
}
