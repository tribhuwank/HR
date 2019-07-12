using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class EmployeeJob:EntityBase
    {
        [ForeignKey("OfficeDepartment_FK")]
        public int? OfficeDepartmentId { get; set; }       
        [ForeignKey("Post_FK")]
        public int? PostId { get; set; }
        [Required]
        public DateTime HiringDate { get; set; }
        [Required]
        public string SymbolNumber { get; set; }
        public DateTime? ProbationPeriodFrom { get; set; }
        public DateTime? ProbationPeriodTo { get; set; }
        public string ProbationPermorfanceSummary { get; set; }
        public string OpinionSuggestion { get; set; }

    }
}
