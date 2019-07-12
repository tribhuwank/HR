using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Occupation : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
