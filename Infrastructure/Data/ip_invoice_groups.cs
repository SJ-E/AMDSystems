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
    
    public partial class ip_invoice_groups
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ip_invoice_groups()
        {
            this.ip_invoices = new HashSet<ip_invoices>();
            this.ip_invoices1 = new HashSet<ip_invoices>();
            this.ip_invoices2 = new HashSet<ip_invoices>();
            this.ip_invoices3 = new HashSet<ip_invoices>();
            this.ip_quotes = new HashSet<ip_quotes>();
        }
    
        public int invoice_group_id { get; set; }
        public string invoice_group_name { get; set; }
        public string invoice_group_identifier_format { get; set; }
        public int invoice_group_next_id { get; set; }
        public int invoice_group_left_pad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoices> ip_invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoices> ip_invoices1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoices> ip_invoices2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_invoices> ip_invoices3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_quotes> ip_quotes { get; set; }
    }
}
