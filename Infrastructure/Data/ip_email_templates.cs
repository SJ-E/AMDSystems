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
    
    public partial class ip_email_templates
    {
        public int email_template_id { get; set; }
        public string email_template_title { get; set; }
        public string email_template_type { get; set; }
        public string email_template_body { get; set; }
        public string email_template_subject { get; set; }
        public string email_template_from_name { get; set; }
        public string email_template_from_email { get; set; }
        public string email_template_cc { get; set; }
        public string email_template_bcc { get; set; }
        public string email_template_pdf_template { get; set; }
    }
}
