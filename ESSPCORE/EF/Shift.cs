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
    
    public partial class Shift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shift()
        {
            this.Employees = new HashSet<Employee>();
            this.ShiftChangeds = new HashSet<ShiftChanged>();
            this.ShiftChangedEmps = new HashSet<ShiftChangedEmp>();
        }
    
        public short PShiftID { get; set; }
        public string ShiftName { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public byte DayOff1 { get; set; }
        public byte DayOff2 { get; set; }
        public short MonMin { get; set; }
        public short TueMin { get; set; }
        public short WedMin { get; set; }
        public short ThuMin { get; set; }
        public short FriMin { get; set; }
        public short SatMin { get; set; }
        public short SunMin { get; set; }
        public short LateIn { get; set; }
        public short EarlyIn { get; set; }
        public short EarlyOut { get; set; }
        public short LateOut { get; set; }
        public short OverTimeMin { get; set; }
        public short MinHrs { get; set; }
        public bool HasBreak { get; set; }
        public short BreakMin { get; set; }
        public short HalfDayBreakMin { get; set; }
        public bool GZDays { get; set; }
        public bool OpenShift { get; set; }
        public bool RoundOffWorkMin { get; set; }
        public bool SubtractOTFromWork { get; set; }
        public bool SubtractEIFromWork { get; set; }
        public bool AddEIInOT { get; set; }
        public bool PresentAtIN { get; set; }
        public bool CalDiffOnly { get; set; }
        public Nullable<int> LocationID { get; set; }
    
        public virtual DaysName DaysName { get; set; }
        public virtual DaysName DaysName1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftChanged> ShiftChangeds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShiftChangedEmp> ShiftChangedEmps { get; set; }
    }
}
