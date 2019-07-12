using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class PayGrade:EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MinSalaryAmount { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]        
        public decimal MaxSalaryAmount { get; set; }
        [Required]
        public int NumberOfLevels { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
