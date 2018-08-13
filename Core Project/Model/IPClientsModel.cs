using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core_Project.Model
{
    public class IPClientsModel
    {

        [Key]
        public int Client_ID
        {
            get; set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name ="Date Created")]
        public DateTime Client_Date_Created
        {
            get; set;
        }

        [Required(AllowEmptyStrings =false)]
        [Display(Name ="Date Modified")]
        public DateTime Client_Date_Modified
        {
            get; set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        [Display(Name = "Name")]
        public string Client_Name
        {
            get; set;
        }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        [Display(Name = "Address 1")]
        public string Client_Address_1
        {
            get; set;
        }

        //[Required(AllowEmptyStrings = true)]
        [Display(Name = "Address 2")]
        public string Client_Address_2
        {
            get; set;
        }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "City is required")]
        [Display(Name = "City")]
        public string Client_City
        {
            get; set;
        }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "State is required")]
        [Display(Name = "State")]
        public string Client_State
        {
            get; set;
        }

        //[Required(AllowEmptyStrings = false)]
        [DataType(DataType.PostalCode)]
        //[RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered format is not valid.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Pin Code must be numeric")]
        [Display(Name = "Pincode")]
        public string Client_Zip
        {
            get; set;
        }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Country is required")]
        [Display(Name = "Country")]
        public string Client_Country
        {
            get; set;
        }

        [Display(Name = "Phone")]
        [Required(ErrorMessage = "Phone Number Required")]
        [RegularExpression(@"^[+]?([0-9]*[\.\s\-\(\)]|[0-9]+){3,24}$", ErrorMessage = "Entered format is not valid.")]
        public string Client_Phone
        {
            get; set;
        }

        [Display(Name = "Fax")]
        //[Required(ErrorMessage = "Fax Number Required")]
        [RegularExpression(@"^[+]?([0-9]*[\.\s\-\(\)]|[0-9]+){3,24}$", ErrorMessage = "Entered format is not valid.")]
        public string Client_Fax
        {
            get; set;
        }

        [Display(Name = "Mobile")]
        //[Required(ErrorMessage = "Mobile Number Required")]
        [RegularExpression(@"^[+]?([0-9]*[\.\s\-\(\)]|[0-9]+){3,24}$", ErrorMessage = "Entered format is not valid.")]
        public string Client_Mobile
        {
            get; set;
        }

        [Display(Name = "Email")]
        //[Required(ErrorMessage = "Email Required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Client_Email
        {
            get; set;
        }

        [Display(Name = "Web")]
        //[Required(ErrorMessage = "Web Required")]
        public string Client_Web
        {
            get; set;
        }

        [Display(Name = "VAT Id")]
        //[Required(ErrorMessage = "VAT id Required")]
        public string Client_VAT_ID
        {
            get; set;
        }

        [Display(Name = "Tax Code")]
        //[Required(ErrorMessage = "Tax code Required")]
        public string Client_Tax_Code
        {
            get; set;
        }

        [Display(Name = "Active")]
        public bool Client_Active
        {
            get; set;
        }

        public int clientType { get; set; }


    }
}
