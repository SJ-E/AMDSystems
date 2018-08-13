using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_Project.Service;
using Core_Project.Model;


namespace Core_Project.Service
{
   public interface IProductService
    {
        IEnumerable<ProductModel> FilterProduct();
        void AddProduct(ProductModel model);
    }
}
