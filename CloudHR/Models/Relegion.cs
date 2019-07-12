
using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Religion: EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
