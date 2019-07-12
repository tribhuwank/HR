using System;
using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Holiday: EntityBase
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }
        [Required]
        public bool IsPublicHoliday { get; set; }
        
    }
}
