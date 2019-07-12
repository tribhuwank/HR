using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class EmployeeDepartMentHistory:EntityBase
    {
        [Required]
        [ForeignKey("Employee_FK1")]
        public int EmployeeId { get; set; }   
        [ForeignKey("Department_FK1")]
        public int? DepartmentId { get; set; }       
        [ForeignKey("Post_FK1")]
        public int? PostId { get; set; }
        [ForeignKey("Department_FK2")]
        public int? TransferOrPromotionDepartmentId { get; set; }
        [ForeignKey("Post_FK2")]
        public int? TransferOrPromotionPostId { get; set; }
        [Required]
        [ForeignKey("PostHistoryType_FK2")]
        public int PostHistoryTypeId { get; set; }//Promotion or Transfer
        [Required]
        public DateTime TransferOrPromotionDate { get; set; }
        public DateTime? LetterIssueDate { get; set; }
        public DateTime? AttendentDeadlineDate { get; set; }

    }
}
