//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaveLife.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesHistory
    {
        public int SaleID { get; set; }
        public Nullable<int> AgentID { get; set; }
        public string ProductName { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
        public Nullable<decimal> SaleAmount { get; set; }
    
        public virtual Agent Agent { get; set; }
    }
}