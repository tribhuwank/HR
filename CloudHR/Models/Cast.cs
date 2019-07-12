using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Cast: EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
