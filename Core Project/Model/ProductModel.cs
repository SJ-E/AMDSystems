using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core_Project.Model
{
    public class ProductModel
    {
        #region Property

        /// <summary>
        /// Gets or sets Id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets Title
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets ImagePath
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets PostedDate
        /// </summary>
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// Gets or sets Publisher
        /// </summary>
        public UserProfileModel Publisher { get; set; }

        #endregion
    }
}
