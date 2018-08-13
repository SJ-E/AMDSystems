using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPQuoteItems
    {
        IEnumerable<IPQuoteItemsModel> FilterIPQuoteItems();
        IPQuoteItemsModel FilterIPQuoteItems(int id);
        void Add(IPQuoteItemsModel iPQuoteItemsModel);
        void Update(IPQuoteItemsModel iPQuoteItemsModel);
        void Update(IEnumerable<IPQuoteItemsModel> iPQuoteItemsModels, int quoteId);
        IEnumerable<IPQuoteItemsModel> FilterIPQuoteItems(IPQuotesModel model);
        IEnumerable<IPQuoteItemsModel> FilterIPQuoteItems(IPPurchaseModel model);
    }
}
