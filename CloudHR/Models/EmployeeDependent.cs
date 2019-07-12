using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class EmployeeDependent:EntityBase
    {
        public Employee Employee { get; set; }
        [Required]
        [ForeignKey("Employee_FK1")]
        public int EmployeeId { get; set; }
        public Person Person { get; set; }
        [Required]
        [ForeignKey("Person_FK1")]
        public int PersonId { get; set; }
        
    }
}
