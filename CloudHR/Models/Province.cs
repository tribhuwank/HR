using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class Province:EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
