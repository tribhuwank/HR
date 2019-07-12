using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Leave:EntityBase
    {
        [Required]
        [ForeignKey("Employee_FK")]
        public int EmployeeId { get; set; }
        [Required]
        public string ReasonForLeav { get; set; }
        [Required]
        [ForeignKey("LeaveType_FK")]
        public int LeaveTypeId { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public DateTime? DateTo { get; set; }
        [Required]
        [ForeignKey("DayType_FK")]
        public int DayTypeId { get; set; }
       
    }
}
