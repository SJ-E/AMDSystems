using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Service
{
    public interface IIPQuotes
    {
        IEnumerable<IPQuotesModel> FilterIPQuotes();
        IPQuotesModel FilterIPQuotes(int id);
        int Add(IPQuotesModel iPQuotesModel);
        void Update(IPQuotesModel iPQuotesModel);
        void UpdateStatus(IPQuotesModel iPQuotesModel);
        void UpdateInvoice(IPQuotesModel iPQuotesModel);
        void DeleteQuote(int quoteId);
        IPQuotesModel FilterIPInvoice(int id);
        IPQuotesModel FilterBilling(int id);
        IEnumerable<IPQuotesModel> FilterBilling();
        IPQuotesModel FilterAllType(int id);
        void QuotetoInvoice(int id);
        int GetQuoteType(int quoteId);
    }
}
