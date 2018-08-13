using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Common;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class IPProductsRepository : IIPProducts
    {
        public AMDSystemsEntities AMDSystemsEntities
        {
            get; set;
        }

        public IPProductsRepository()
        {
            AMDSystemsEntities = new AMDSystemsEntities();
        }

        public bool Add(IPProductsModel iPProductsModel)
        {
            if (iPProductsModel == null)
            {
                //throw new ArgumentNullException(nameof(iPProductsModel));
            }

            var allIPProductsDB = AMDSystemsEntities.ip_products.Select(p => p).Where(e => !(e.isdelete.HasValue && e.isdelete.Value)).Where(e => e.serial_number == iPProductsModel.serial_number).FirstOrDefault();
            if (allIPProductsDB != null)
            {
                return false;
            }
            ip_products ipProductsDB = Mapper.Map(iPProductsModel, new ip_products());
            AMDSystemsEntities.ip_products.Add(ipProductsDB);
            AMDSystemsEntities.SaveChanges();
            return true;
        }

        public IEnumerable<IPProductsModel> FilterIPProducts()
        {
            var allIPProductsDB = AMDSystemsEntities.ip_products.Select(p => p).Where(e => !(e.isdelete.HasValue && e.isdelete.Value)).OrderByDescending(e=> e.product_id).ToList();
            var allIPProductsModel = new List<IPProductsModel>();
            allIPProductsDB.ForEach(c => allIPProductsModel.Add(Mapper.Convert(c)));
            return allIPProductsModel;
        }


        public IEnumerable<IPProductsModel> FilterIPProducts(string keyword,int page, int size =10 )
        {
            var allIPProductsDB = AMDSystemsEntities.ip_products.Select(e=>e).Where(e => !(e.isdelete.HasValue && e.isdelete.Value));
            if (!string.IsNullOrEmpty(keyword))
            {
                allIPProductsDB = allIPProductsDB.Where(p => p.product_name.Contains(keyword));
            }
            var allIPProductsModel = new List<IPProductsModel>();
            allIPProductsDB.ToList().ForEach(c => allIPProductsModel.Add(Mapper.Convert(c)));
            return allIPProductsModel;
        }

        public IPProductsModel FilterIPProducts(int id)
        {
            var ipProductsDB = AMDSystemsEntities.ip_products.Where(p => p.product_id == id).FirstOrDefault();
            var ipProducts = Mapper.Convert(ipProductsDB);
            return ipProducts;
        }

        public void Update(IPProductsModel ipProductsModel)
        {
            if (ipProductsModel == null)
            {
                //throw new ArgumentNullException(nameof(ipProductsModel));
            }

            var ipProductsDB = AMDSystemsEntities.ip_products.Where(p => p.product_id == ipProductsModel.product_id).FirstOrDefault();
            Mapper.Map(ipProductsModel, ipProductsDB);
            AMDSystemsEntities.SaveChanges();
        }

        public void Delete(int productId)
        {
            var ipProductDB = AMDSystemsEntities.ip_products.Where(c => c.product_id == productId).FirstOrDefault();
            if (ipProductDB != null)
            {
                ipProductDB.isdelete = true;                
                AMDSystemsEntities.SaveChanges();
            }
        }
    }
}
