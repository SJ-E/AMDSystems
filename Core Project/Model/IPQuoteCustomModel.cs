using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPQuoteCustomModel
    {
        [Key]
        public int quote_custom_id
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name ="Quote Id")]
        public int quote_id
        {
            get; set;
        }
    }
}
