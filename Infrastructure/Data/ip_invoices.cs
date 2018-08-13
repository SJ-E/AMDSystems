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
    
    public partial class ip_invoices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ip_invoices()
        {
            this.ip_invoice_amounts = new HashSet<ip_invoice_amounts>();
            this.ip_invoice_amounts1 = new HashSet<ip_invoice_amounts>();
            this.ip_invoice_amounts2 = new HashSet<ip_invoice_amounts>();
            this.ip_invoice_custom = new HashSet<ip_invoice_custom>();
            this.ip_invoice_custom1 = new HashSet<ip_invoice_custom>();
        }
    
        public int invoice_id { get; set; }
        public int user_id { get; set; }
        public int client_id { get; set; }
        public int invoice_group_id { get; set; }
        public short invoice_status_id { get; set; }
        public Nullable<short> is_read_only { get; set; }
        public string invoice_password { get; set; }
        public System.DateTime invoice_date_created { get; set; }
        public System.TimeSpan invoice_time_created { get; set; }
        public System.DateTime invoice_date_modified { get; set; }
        public System.DateTime invoice_date_due { get; set; }
        public string invoice_number { get; set; }
        public Nullable<decimal> invoice_discount_amount { get; set; }
        public Nullable<decimal> invoice_discount_percent { get; set; }
        public string invoice_terms { get; set; }
        public string invoice_url_key { get; set; }
        public int payment_method { get; set; }
        public Nullable<int> creditinvoice_parent_id { get; set; }
    
        public virtual ip_clients ip_clients { get; set; }
        public virtual ip_clients ip_clients1 { get; set; }
        public virtual ip_clients ip_clients2 { get; set; }
        public virtual ip_clients ip_clients3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoice_amounts> ip_invoice_amounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoice_amounts> ip_invoice_amounts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoice_amounts> ip_invoice_amounts2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoice_custom> ip_invoice_custom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoice_custom> ip_invoice_custom1 { get; set; }
        public virtual ip_invoice_groups ip_invoice_groups { get; set; }
        public virtual ip_invoice_groups ip_invoice_groups1 { get; set; }
        public virtual ip_invoice_groups ip_invoice_groups2 { get; set; }
        public virtual ip_invoice_groups ip_invoice_groups3 { get; set; }
        public virtual ip_users ip_users { get; set; }
        public virtual ip_users ip_users1 { get; set; }
        public virtual ip_users ip_users2 { get; set; }
    }
}