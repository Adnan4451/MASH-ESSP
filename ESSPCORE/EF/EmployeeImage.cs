//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESSPCORE.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeImage
    {
        public int PEmpID { get; set; }
        public byte[] EmpPic { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
