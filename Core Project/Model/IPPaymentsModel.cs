using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Core_Project.Model
{
    public class IPPaymentsModel
    {
        public List<IPQuotesModel> iPQuotesModels
        {
            get;
            set;
        }

        [Key]
        public int payment_id { get; set; }

        public int quote_id { get; set; }

        public int payment_method_id { get; set; }

        [Required(ErrorMessage = "Amount Paid is required.")]
        [MaxLength(12)]
        [MinLength(1)]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Enter must be numeric")]
        public decimal payment_amount { get; set; }

        public string payment_note { get; set; }

        public DateTime payment_date { get; set; }

        

    }
}
