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
    
    public partial class vwCurrentUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public System.DateTime LastLoggedOn { get; set; }
        public Nullable<int> UserGroup { get; set; }
        public string SAPSystem { get; set; }
        public string DecimalSeparator { get; set; }
        public string ThousandSeparator { get; set; }
        public string DateFormat { get; set; }
        public string Language { get; set; }
        public string ProductionPlant { get; set; }
        public string BwHana { get; set; }
    }
}
