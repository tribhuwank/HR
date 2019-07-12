using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class DayType:EntityBase
    {
        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
