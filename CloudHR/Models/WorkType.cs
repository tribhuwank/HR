using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class WorkType: EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
