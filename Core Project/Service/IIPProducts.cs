using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPProducts
    {
        IEnumerable<IPProductsModel> FilterIPProducts();
        IPProductsModel FilterIPProducts(int id);
        bool Add(IPProductsModel iPProductsModel);
        void Update(IPProductsModel iPProductsModel);
        void Delete(int productId);
        IEnumerable<IPProductsModel> FilterIPProducts(string keyword, int page, int size = 10);
    }
}
