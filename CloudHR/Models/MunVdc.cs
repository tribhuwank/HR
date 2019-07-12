using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class MunVdc:EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int VdcMunType { get; set; }
        [Required]
        [ForeignKey("District_FK")]
        public int DistrictId { get; set; }
        [Required]
        public int WardCount { get; set; }
    }
}
