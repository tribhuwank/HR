using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class CarbonCopyer:EntityBase
    {
        [Required]
        [ForeignKey("Employee_FK1")]
        public int EmployeeId { get; set; }        
        public int? HistoryId { get; set; }        
        [Required]
        public int CarbonCopyFor { get; set; }//0-Appointment, 1-TransferorPromotion, 2-Leave  
        [Required]
        public bool IsApproved { get; set; }
        [Required]
        public bool IsCanceled { get; set; }
        [Required]
        public int PermisionHirarchy { get; set; }
    }
}
