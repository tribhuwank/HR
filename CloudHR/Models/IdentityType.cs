using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class IdentityType:EntityBase
    {
        [Required]
        public string Name { get; set; } 
    }
}
