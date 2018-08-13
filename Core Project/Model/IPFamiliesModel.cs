using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPFamiliesModel
    {
        [Key]
        public int family_id
        {
            get; set;
        }
        
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Name")]
        public string family_name
        {
            get; set;
        }
    }
}
