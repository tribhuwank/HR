using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Education : EntityBase
    {
        [Required]
        public string Name { get; set; }

    }
}
