using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Skill : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
