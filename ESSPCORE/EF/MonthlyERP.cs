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
    
    public partial class MonthlyERP
    {
        public int PMonthlyERPID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string OEmpID { get; set; }
        public Nullable<double> TotalDays { get; set; }
        public Nullable<double> LWOPDays { get; set; }
        public Nullable<int> SingleOTMins { get; set; }
        public Nullable<int> DoubleOTMins { get; set; }
        public Nullable<int> PayrollPeriodID { get; set; }
        public Nullable<System.DateTime> ProcessedDate { get; set; }
        public Nullable<bool> IsProcessed { get; set; }
        public string Remarks { get; set; }
    }
}