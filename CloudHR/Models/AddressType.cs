using System.ComponentModel.DataAnnotations;

namespace CloudHR.Models
{
    public class AddressType:EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
