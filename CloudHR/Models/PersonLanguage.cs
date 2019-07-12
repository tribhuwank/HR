using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class PersonLanguage: EntityBase
    {
        [Required]
        public int PersonId { get; set; }
        [Required]
        public int LanguageId { get; set; }

    }
}
