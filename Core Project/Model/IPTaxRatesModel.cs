using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPTaxRatesModel
    {
        public int tax_rate_id { get; set; }
        [Required]
        public decimal tax_rate_percent { get; set; }
        [Required]
        public string tax_rate_name { get; set; }
    }
}
