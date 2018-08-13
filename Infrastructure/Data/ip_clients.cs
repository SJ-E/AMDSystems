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
    
    public partial class ip_clients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ip_clients()
        {
            this.ip_client_custom = new HashSet<ip_client_custom>();
            this.ip_client_custom1 = new HashSet<ip_client_custom>();
            this.ip_client_custom2 = new HashSet<ip_client_custom>();
            this.ip_client_custom3 = new HashSet<ip_client_custom>();
            this.ip_client_custom4 = new HashSet<ip_client_custom>();
            this.ip_client_custom5 = new HashSet<ip_client_custom>();
            this.ip_client_custom6 = new HashSet<ip_client_custom>();
            this.ip_client_custom7 = new HashSet<ip_client_custom>();
            this.ip_client_custom8 = new HashSet<ip_client_custom>();
            this.ip_client_notes = new HashSet<ip_client_notes>();
            this.ip_client_notes1 = new HashSet<ip_client_notes>();
            this.ip_invoices = new HashSet<ip_invoices>();
            this.ip_invoices1 = new HashSet<ip_invoices>();
            this.ip_invoices2 = new HashSet<ip_invoices>();
            this.ip_invoices3 = new HashSet<ip_invoices>();
            this.ip_quotes = new HashSet<ip_quotes>();
        }
    
        public int client_id { get; set; }
        public System.DateTime client_date_created { get; set; }
        public System.DateTime client_date_modified { get; set; }
        public string client_name { get; set; }
        public string client_address_1 { get; set; }
        public string client_address_2 { get; set; }
        public string client_city { get; set; }
        public string client_state { get; set; }
        public string client_zip { get; set; }
        public string client_country { get; set; }
        public string client_phone { get; set; }
        public string client_fax { get; set; }
        public string client_mobile { get; set; }
        public string client_email { get; set; }
        public string client_web { get; set; }
        public string client_vat_id { get; set; }
        public string client_tax_code { get; set; }
        public int client_active { get; set; }
        public Nullable<bool> isdelete { get; set; }
        public Nullable<int> clientType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_custom> ip_client_custom8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_notes> ip_client_notes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ip_client_notes> ip_client_notes1 { get; set; }
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