using System;
using Core_Project.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPEstimate
    {
        IEnumerable<IPEstimateModel> FilterIPEstimate();
        IPEstimateModel FilterIPEstimate(int id);
        void Add(IPEstimateModel iPEstimateModel);
    }
}
