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
    
    public partial class ip_quote_items
    {
        public int item_id { get; set; }
        public int quote_id { get; set; }
        public Nullable<int> item_product_id { get; set; }
        public System.DateTime item_date_added { get; set; }
        public string item_name { get; set; }
        public string item_description { get; set; }
        public Nullable<decimal> item_quantity { get; set; }
        public Nullable<decimal> item_price { get; set; }
        public Nullable<decimal> item_discount_amount { get; set; }
        public int item_order { get; set; }
        public string item_serial { get; set; }
    
        public virtual ip_products ip_products { get; set; }
        public virtual ip_quotes ip_quotes { get; set; }
    }
}
