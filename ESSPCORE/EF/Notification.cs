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
    
    public partial class Notification
    {
        public int PNotificationID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string NotificationURL { get; set; }
        public Nullable<int> NotificationTypeID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> InactiveDate { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> PID { get; set; }
    }
}
