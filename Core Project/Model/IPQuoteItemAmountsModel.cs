using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPQuoteItemAmountsModel
    {
        [Key]
        public int item_amount_id
        {
            get; set;
        }
        [Display(Name ="Item Id")]
        public int item_id
        {
            get; set;
        }
        [Display(Name ="SubTotal")]
        public Nullable<decimal> item_subtotal
        {
            get; set;
        }
        [Display(Name ="Tax Total")]
        public Nullable<decimal> item_tax_total
        {
            get; set;
        }
        [Display(Name ="Discount")]
        public Nullable<decimal> item_discount
        {
            get; set;
        }
        [Display(Name ="Total")]
        public Nullable<decimal> item_total
        {
            get; set;
        }
    }
}
