using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Litracy : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
