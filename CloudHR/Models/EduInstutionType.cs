using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class EduInstutionType : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
