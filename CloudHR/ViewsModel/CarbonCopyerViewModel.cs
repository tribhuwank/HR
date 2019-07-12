using System;

namespace CloudHR.ViewsModel
{
    public class CarbonCopyerViewModel:BaseViewModel
    {
        public int EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public int? HistoryId { get; set; }  
        public int CarbonCopyFor { get; set; }//0-Appointment, 1-TransferorPromotion, 2-Leave 
        public bool IsApproved { get; set; }
        public bool IsCanceled { get; set; }
        public int PermisionHirarchy { get; set; }
    }
}
