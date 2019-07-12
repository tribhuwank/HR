using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Approver:EntityBase
    {
        [Required]
        [ForeignKey("Employee_FK1")]
        public int EmployeeId { get; set; }
        [Required]
        [ForeignKey("Employee_FK2")]
        public int ApproverEmployeeId { get; set; }
        [Required]
        public int ApproverFor { get; set; }//0-Appointment, 1-TransferorPromotion, 2-Leave       
        public int? ApproveHistoryId { get; set; }
        [Required]
        public bool IsApproved { get; set; }
        [Required]
        public bool IsCanceled { get; set; }
        [Required]
        public int PermisionHirarchy { get; set; }
    }
}
