using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Relation:EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
