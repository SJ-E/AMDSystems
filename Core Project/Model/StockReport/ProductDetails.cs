using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model.StockReport
{
    public class ProductDetails
    {

        public ProductDetails()
        {
            ProductId = 0;
            ProductName = string.Empty;
            StartDate = DateTime.Now.AddMonths(-1);
            EndDate = DateTime.Now;
            Transactions = new List<QuoteItemsDetails>();
            TotalQuantiyInStock = 0;
        }

        [Display(Name = "ID")]
        public int ProductId
        {
            get; set;
        }

        [Display(Name = "Name")]
        public string ProductName
        {
            get;
            set;
        }

        [Display(Name = "Transactions")]
        public List<QuoteItemsDetails> Transactions
        {
            get;
            set;
        }
        
        [Display(Name = "Total Quantiy In Stock")]
        public int TotalQuantiyInStock
        {
            get; set;
        }

        [Display(Name = "Start Time")]
        public DateTime StartDate
        {
            get;
            set;
        }

        [Display(Name = "End Time")]
        public DateTime EndDate
        {
            get;
            set;
        }

    }
}
