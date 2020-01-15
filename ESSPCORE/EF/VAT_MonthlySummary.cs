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
    
    public partial class VAT_MonthlySummary
    {
        public Nullable<int> EmployeeID { get; set; }
        public string PRName { get; set; }
        public Nullable<System.DateTime> PRStartDate { get; set; }
        public Nullable<System.DateTime> PREndDate { get; set; }
        public Nullable<int> PayrollPeriodID { get; set; }
        public string MonthDataOTStageName { get; set; }
        public string MonthDataStageID { get; set; }
        public Nullable<double> TotalDays { get; set; }
        public Nullable<double> WorkDays { get; set; }
        public Nullable<double> PresentDays { get; set; }
        public Nullable<double> AbsentDays { get; set; }
        public Nullable<double> RestDays { get; set; }
        public Nullable<double> GZDays { get; set; }
        public Nullable<double> LeaveDays { get; set; }
        public Nullable<double> HPLeaveDays { get; set; }
        public Nullable<double> WOPLeavesDays { get; set; }
        public Nullable<short> TotalShortMins { get; set; }
        public Nullable<double> HalfLeavesDays { get; set; }
        public Nullable<double> HalfAbsentDays { get; set; }
        public Nullable<double> CLDay { get; set; }
        public Nullable<double> ALDay { get; set; }
        public Nullable<double> SLDay { get; set; }
        public Nullable<double> CPLDay { get; set; }
        public Nullable<double> GZPresentDays { get; set; }
        public Nullable<double> RestPresentDays { get; set; }
        public Nullable<double> OfficialDutyDays { get; set; }
        public Nullable<short> TEarlyIn { get; set; }
        public Nullable<short> TEarlyOut { get; set; }
        public Nullable<short> TLateIn { get; set; }
        public Nullable<short> TLateOut { get; set; }
        public Nullable<short> TWorkTime { get; set; }
        public Nullable<short> TNOT { get; set; }
        public Nullable<short> TROT { get; set; }
        public Nullable<short> TGZOT { get; set; }
        public Nullable<short> CPLConversionOT { get; set; }
        public Nullable<short> TotalLossWorkMin { get; set; }
        public Nullable<short> TotalExtraWorkMin { get; set; }
        public Nullable<short> ExpectedWorkTime { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> FPID { get; set; }
        public string EmployeeName { get; set; }
        public string TelephoneNo { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string CNIC { get; set; }
        public string FatherName { get; set; }
        public string Status { get; set; }
        public Nullable<int> EmploymentTypeID { get; set; }
        public Nullable<int> DesigationID { get; set; }
        public Nullable<int> JobTitleID { get; set; }
        public Nullable<int> GradeID { get; set; }
        public Nullable<int> OUID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<System.DateTime> ResignDate { get; set; }
        public Nullable<short> ShiftID { get; set; }
        public string CardNo { get; set; }
        public Nullable<System.DateTime> ValidDate { get; set; }
        public Nullable<bool> FaceTemp { get; set; }
        public Nullable<bool> ProcessAttendance { get; set; }
        public Nullable<short> OTPolicyID { get; set; }
        public string LocationName { get; set; }
        public string EmploymentTypeName { get; set; }
        public string GradeName { get; set; }
        public string OGradeID { get; set; }
        public string DesignationName { get; set; }
        public string ODesignationID { get; set; }
        public string OEmployeementTypeID { get; set; }
        public string OLocationID { get; set; }
        public string OTPolicyName { get; set; }
        public string ShiftName { get; set; }
        public string OEmpID { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        public string CrewName { get; set; }
        public Nullable<int> CrewID { get; set; }
        public Nullable<int> ALPolicyID { get; set; }
        public string ALPolicyName { get; set; }
        public Nullable<int> CLPolicyID { get; set; }
        public string CLPolicyName { get; set; }
        public Nullable<int> SLPolicyID { get; set; }
        public string SLPolicyName { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> CPLPolicyID { get; set; }
        public string CPLPolicyName { get; set; }
        public Nullable<bool> FPTemp { get; set; }
        public string OUName { get; set; }
        public string OOUID { get; set; }
        public string OUCommonName { get; set; }
        public Nullable<int> OUCommonID { get; set; }
        public string JobTitleName { get; set; }
        public string OJobTitleID { get; set; }
        public Nullable<int> JTCommonID { get; set; }
        public string JTCommonName { get; set; }
        public string FYName { get; set; }
        public Nullable<System.DateTime> FYStartDate { get; set; }
        public Nullable<System.DateTime> FYEndDate { get; set; }
        public Nullable<int> FinancialYearID { get; set; }
        public long PMonthDataID { get; set; }
        public Nullable<short> EncashbaleSingleOT { get; set; }
        public Nullable<short> EncashbaleDoubleOT { get; set; }
        public Nullable<double> CPLConvertedDays { get; set; }
        public Nullable<int> SubmittedToUserID { get; set; }
        public string SubmittedToUserName { get; set; }
    }
}