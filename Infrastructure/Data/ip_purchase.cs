//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ip_purchase
    {
        public int quote_id { get; set; }
        public int invoice_id { get; set; }
        public int user_id { get; set; }
        public int client_id { get; set; }
        public int invoice_group_id { get; set; }
        public short quote_status_id { get; set; }
        public System.DateTime quote_date_created { get; set; }
        public System.DateTime quote_date_modified { get; set; }
        public System.DateTime quote_date_expires { get; set; }
        public string quote_number { get; set; }
        public Nullable<decimal> quote_discount_amount { get; set; }
        public Nullable<decimal> quote_discount_percent { get; set; }
        public string quote_url_key { get; set; }
        public string quote_password { get; set; }
        public string notes { get; set; }
    }
}
