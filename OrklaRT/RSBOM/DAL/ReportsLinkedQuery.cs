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
    
    public partial class ReportsLinkedQuery
    {
        public int ID { get; set; }
        public int ReportID { get; set; }
        public int SubReports { get; set; }
        public string SheetName { get; set; }
        public string ListObjectName { get; set; }
        public string QueryName { get; set; }
    }
}
