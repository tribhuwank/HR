using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Country:EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
    }
}
