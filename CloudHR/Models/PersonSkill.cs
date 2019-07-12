using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class PersonSkill:EntityBase
    {
        [Required]
        public int PersonId { get; set; }
        [Required]
        public int SkillId { get; set; }
    }
}
