using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model.StockReport
{
    public class QuoteItemsDetails
    {
        public QuoteItemsDetails()
        {
            TransactionQuantity = 0;
            TransactionDate = new DateTime();
        }

        [Display(Name = "Quantity")]
        public int TransactionQuantity
        {
            get; set;
        }

        [Display(Name = "Type")]
        public TransactionType TransactionType
        {
            get; set;
        }

        [Display(Name = "Date")]
        public System.DateTime TransactionDate
        {
            get; set;
        }

    }

    public enum TransactionType
    {
        Quote = 0,
        Invoice = 1,
        Purchase = 2,
        Payment = 3
    }
}
