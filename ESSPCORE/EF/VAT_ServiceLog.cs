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
    
    public partial class VAT_ServiceLog
    {
        public byte ErrorCode { get; set; }
        public string Description { get; set; }
        public System.DateTime DateTime { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> LocID { get; set; }
        public short IpPort { get; set; }
        public string ReaderName { get; set; }
        public string IpAdd { get; set; }
        public short PReaderID { get; set; }
        public string ReaderDutyName { get; set; }
        public int PServiceLogID { get; set; }
        public Nullable<bool> Processed { get; set; }
    }
}