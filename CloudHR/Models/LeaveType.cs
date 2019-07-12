using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class LeaveType:EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
