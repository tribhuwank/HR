using System;

namespace CloudHR.ViewsModel
{
    public class ApproverViewModel:BaseViewModel
    {
        public int EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public int ApproverEmployeeId { get; set; }
        public int ApproverFor { get; set; }//0-Appointment, 1-TransferorPromotion, 2-Leave       
        public int? ApproveHistoryId { get; set; }
        public bool IsApproved { get; set; }
        public bool IsCanceled { get; set; }
        public int PermisionHirarchy { get; set; }
    }
}
