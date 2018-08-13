using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPClientCustomModel
    {
        [Key]
        public int Client_Custom_ID
        {
            get;
            set;
        }
        [Display(Name = "Client Id")]
        public int Client_ID
        {
            get;
            set;
        }
    }
}
