using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
   public  class IPInvoiceAmountsModel
    {
        [Key]
       public int invoice_amount_id
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote Id")]
        public int invoice_id
        {
            get;
            set;
        }
        [Display(Name = "Item SubTotal")]
        public Nullable<decimal> invoice_item_subtotal
        {
            get;
            set;
        }
        [Display(Name = "Item Tax Total")]
        public Nullable<decimal> invoice_item_tax_total
        {
            get;
            set;
        }
        [Display(Name = "Tax Total")]
        public Nullable<decimal> invoice_tax_total
        {
            get;
            set;
        }
        [Display(Name = "Total")]
        public Nullable<decimal> invoice_total
        {
            get;
            set;
        }

        [Display(Name = "Paid")]
        public Nullable<decimal> invoice_paid
        {
            get;
            set;
        }

        [Display(Name = "Balance")]
        public Nullable<decimal> invoice_balance
        {
            get;
            set;
        }
    }
}
