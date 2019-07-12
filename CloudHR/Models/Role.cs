using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Role : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
