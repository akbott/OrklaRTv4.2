//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PPLockedOrders
    {
        public int ID { get; set; }
        public string Plant { get; set; }
        public Nullable<int> OrderNumber { get; set; }
        public System.DateTime LockedDate { get; set; }
        public int UserId { get; set; }
    }
}