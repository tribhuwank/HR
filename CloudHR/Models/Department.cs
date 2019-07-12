using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Department: EntityBase
    {
        [Required]
        public string Name { get; set; }
        public string DeptNumber { get; set; }
        public string Location { get; set; }
        [Required]
        [ForeignKey("Office_FK")]
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        
    }
}
