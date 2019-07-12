using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class District:EntityBase
    {
        [Required]
        public string Name { get; set; }
        public Province Province { get; set; }
        [Required]
        [ForeignKey("Province_FK")]
        public int ProvinceId { get; set; }
    }
}
