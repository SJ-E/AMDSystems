using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPQuoteItemsModel
    {
        [Key]
        public int item_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings =false)]
        [Display(Name ="Quote Id")]
        public int quote_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Tax Rate Id")]
        public int item_tax_rate_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Product Id")]
        public Nullable<int> item_product_id
        {
            get; set;
        }
        public System.DateTime item_date_added
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote Name")]
        public string item_name
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Description")]
        public string item_description
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quantity")]
        public Nullable<decimal> item_quantity
        {
            get; set;
        }
        public Nullable<decimal> item_price
        {
            get; set;
        }
        public Nullable<decimal> item_discount_amount
        {
            get; set;
        }
        public int item_order
        {
            get; set;
        }
        public string item_serial
        {
            get; set;
        }

        public IPProductsModel product { get; set; }
    }
}
