using System.ComponentModel.DataAnnotations;
namespace CloudHR.Models
{
    public class PostHistoryType:EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}
