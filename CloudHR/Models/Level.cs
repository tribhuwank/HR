using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Level:EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey("PayGrade_FK")]
        public int PayGradeId { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal GradePerMonth { get; set; }
        [Required]
        public int? GradeUpgradationMonth { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal GradeUpgradationRate { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MaxGradeValue { get; set; }
        [Required]
        public bool IsActive { get; set; }

    }
}
