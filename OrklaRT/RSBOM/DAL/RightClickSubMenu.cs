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
    
    public partial class RightClickSubMenu
    {
        public int ID { get; set; }
        public int RightClickMenuID { get; set; }
        public string Caption { get; set; }
        public string FunctionName { get; set; }
        public bool BeginGroup { get; set; }
    }
}
