using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class MaritalStatus: EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
