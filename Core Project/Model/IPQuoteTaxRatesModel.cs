using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPQuoteTaxRatesModel
    {
        [Key]
        public int quote_tax_rate_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name ="Quote Id")]
        public int quote_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Tax Rate Id")]
        public int tax_rate_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Include Item Tax")]
        public int include_item_tax
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote Tax Rate Amount")]
        public Nullable<decimal> quote_tax_rate_amount
        {
            get; set;
        }
    }
}
