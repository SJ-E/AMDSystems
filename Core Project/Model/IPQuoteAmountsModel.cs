using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPQuoteAmountsModel
    {
        [Key]
        public int quote_amount_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name ="Quote Id")]
        public int quote_id
        {
            get; set;
        }
        [Display(Name ="Item SubTotal")]
        public Nullable<decimal> quote_item_subtotal
        {
            get; set;
        }
        [Display(Name ="Item Tax Total")]
        public Nullable<decimal> quote_discount
        {
            get; set;
        }
        [Display(Name ="Tax Total")]
        public Nullable<decimal> quote_tax_total
        {
            get; set;
        }
        [Display(Name ="Total")]
        public Nullable<decimal> quote_total
        {
            get; set;
        }
    }
}
