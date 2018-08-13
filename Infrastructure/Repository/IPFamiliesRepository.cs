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
    public class IPFamiliesRepository:IIPFamilies
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }
        public IPFamiliesRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public IEnumerable<IPFamiliesModel> FilterIPFamilies()
        {
            var allIPFamiliesDB = AMDSystemsEntities.ip_families.Select(f => f).ToList();
            var allIPFamiliesModel = new List<IPFamiliesModel>();
            allIPFamiliesDB.ForEach(p => allIPFamiliesModel.Add(Mapper.Convert(p)));
            return allIPFamiliesModel;
        }

        public IPFamiliesModel FilterIPFamilies(int id)
        {
            var ipFamiliesDB = AMDSystemsEntities.ip_families.Where(f => f.family_id == id).Select(f => f).FirstOrDefault();
            var iPFamiliesModel = Mapper.Convert(ipFamiliesDB);
            return iPFamiliesModel;
        }

        public void Add(IPFamiliesModel iPFamiliesModel)
        {
            if (iPFamiliesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPFamiliesModel));
            }

            ip_families ipFamiliesDB = Mapper.Map(iPFamiliesModel, new ip_families());
            AMDSystemsEntities.ip_families.Add(ipFamiliesDB);
            AMDSystemsEntities.SaveChanges();
        }

        public void Update(IPFamiliesModel iPFamiliesModel)
        {
            if (iPFamiliesModel == null)
            {
                //throw new ArgumentNullException(nameof(iPFamiliesModel));
            }

            var ipFamiliesDB = AMDSystemsEntities.ip_families.Where(p => p.family_id == iPFamiliesModel.family_id).FirstOrDefault();
            Mapper.Map(iPFamiliesModel, ipFamiliesDB);
            AMDSystemsEntities.SaveChanges();
        }
    }
}
