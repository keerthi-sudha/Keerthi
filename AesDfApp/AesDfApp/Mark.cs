//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AesDfApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mark
    {
        public int marks { get; set; }
        public string sregno { get; set; }
        public int subid { get; set; }
    
        public virtual Student_table Student_table { get; set; }
        public virtual Subject Subject { get; set; }
    }
}