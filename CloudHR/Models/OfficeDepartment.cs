using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class OfficeDepartment: EntityBase
    {
        [Required]
        [ForeignKey("Department_FK")]
        public int DepartmentId { get; set; }
        [Required]
        [ForeignKey("Office_FK")]
        public int OfficeId { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
