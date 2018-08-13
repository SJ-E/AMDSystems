using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core_Project.Model
{
    public class IPProductsModel
    {
        [Key]
        public int product_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Family Id")]
        public int? family_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "SKU")]
        public string product_sku
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Name")]
        public string product_name
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Description")]
        public string product_description
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Price")]
        [RegularExpression(@"^[1-9]\d{0,7}(?:\.\d{1,4})?|\.\d{1,4}$", ErrorMessage = "Invalid price")]
        public decimal? product_price
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        //[RegularExpression(@"[1-9]\d{0,7}(?:[.,]\d{1,4})*(?:[.,]\d{2})?", ErrorMessage = "Purchase Price must be numeric")]
        [Display(Name = "Purchase Price")]
        public decimal? purchase_price
        {
            get; set;
        }
        [Display(Name = "Provider Name")]
        public string provider_name
        {
            get; set;
        }
        [Display(Name = "Tax Rate Id")]
        public int? tax_rate_id
        {
            get; set;
        }
        [Display(Name = "Quantity")]
        public int? quantity
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Sub Category")]
        public string sub_cate
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Serial Number")]
        public string serial_number
        {
            get; set;
        }
        [Display(Name = "Supplier Name")]
        public string supp_name
        {
            get; set;
        }
        [Display(Name = "Warranty Detail")]
        public string warenty_detail
        {
            get; set;
        }
        [Display(Name = "Selling Price")]
       // [RegularExpression(@"[1-9]\d{0,7}(?:[.,]\d{1,4})*(?:[.,]\d{2})?", ErrorMessage = "Selling price must be numeric")]
        public string selling_price
        {
            get; set;
        }
        [Display(Name = "Other Info")]
        public string other_info
        {
            get; set;
        }
        [Display(Name = "Purchase Original Price")]
        //[RegularExpression(@"[1-9]\d{0,7}(?:[.,]\d{1,4})*(?:[.,]\d{2})?", ErrorMessage = "Purchase original price must be numeric")]
        public string purchase_org_price
        {
            get; set;
        }

        public IPTaxRatesModel tax_Model {get;set;}

        public IPFamiliesModel family_Model { get; set; }
    }
}
