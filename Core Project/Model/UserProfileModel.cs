using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core_Project.Model
{
    /// <summary>
    /// Model for the user Profile 
    /// </summary>
    public class UserProfileModel
    {
        #region  Property 

        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets Email
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Phone Number
        /// </summary>
        [Required]
        [StringLength(10,MinimumLength =9)]
        public string PhoneNo { get; set; }

      
        #endregion

    }
}
