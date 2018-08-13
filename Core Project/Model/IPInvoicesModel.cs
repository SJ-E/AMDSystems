using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Project.Model
{
    public class IPInvoicesModel
    {
        [Key]
        public int quote_id
        {
            get;
            set;
        }
        //[Required(AllowEmptyStrings = false)]
        //[Display(Name = "Invoice Id")]
        //public int invoice_id
        //{
        //    get; set;
        //}
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "User Id")]
        public int user_id
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Client Id")]
        public int client_id
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Invoice Group Id")]
        public int invoice_group_id
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote Status Id")]
        public short quote_status_id
        {
            get;
            set;
        }
        public System.DateTime quote_date_created
        {
            get;
            set;
        }
        public System.DateTime quote_date_modified
        {
            get;
            set;
        }
        public System.DateTime quote_date_expires
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote Number")]
        public string quote_number
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote Discount Amount")]
        public Nullable<decimal> quote_discount_amount
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote Discount Percent")]
        public Nullable<decimal> quote_discount_percent
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote URL Key")]
        public string quote_url_key
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Quote Password")]
        public string quote_password
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Notes")]
        public string notes
        {
            get;
            set;
        }
        [Required]
        [Display(Name = "Notes")]
        public int taxType
        {
            get;
            set;
        }
        public bool isquote { get; set; }

        public int type { get; set; }
        public string client_name { get; set; }

        public decimal? invoice_total { get; set; }



        #region object

        public IPUsersModel user { get; set; }
        public IPClientsModel client { get; set; }
        public IEnumerable<IPQuoteItemsModel> quote_items { get; set; }
        public IPQuoteAmountsModel quote_amount { get; set; }
        public IPInvoiceAmountsModel invoice_amount { get; set; }
        public IPQuoteTaxRatesModel quote_tax_rate { get; set; }

        #endregion
    }
}
