using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Core_Project.Model
{
    public class ReportSearch
    {
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "From Date")]
        public DateTime startDate
        {
            get; set;
        }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "To Date")]
        public DateTime endDate
        {
            get; set;
        }

        public IEnumerable<IPQuotesModel> lstQuotes
        {
            get; set;
        }

        public IEnumerable<IPPaymentsModel> lstPayments
        {
            get; set;
        }

        public bool ReportVisible
        {
            get; set;
        }

        public int Type
        {
            get; set;
        }

    }
}
