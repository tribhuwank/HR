using System;
using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class PersonEducation : EntityBase
    {
        [Required]
        public int EducationId { get; set; }
        [Required]
        public string Level { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDateDate { get; set; }
        public string Institution { get; set; }
        public string InstitutionAddress { get; set; }

    }
}
