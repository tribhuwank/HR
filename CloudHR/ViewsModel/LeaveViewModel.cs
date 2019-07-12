using System;
using System.Collections.Generic;

namespace CloudHR.ViewsModel
{
    public class LeaveViewModel:BaseViewModel
    {
        public int EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public string ReasonForLeav { get; set; }       
        public int LeaveTypeId { get; set; }
        public LeaveTypeViewModel LeaveType { get; set; }
        public DateTime DateFrom { get; set; }        
        public DateTime? DateTo { get; set; }       
        public int DayTypeId { get; set; }
        public DayTypeViewModel DayType { get; set; }
        public bool IsApproved { get; set; }
        public IList<CarbonCopyerViewModel> CcTos { get; set; }
        public IList<ApproverViewModel> Approvers { get; set; }
    }
}
