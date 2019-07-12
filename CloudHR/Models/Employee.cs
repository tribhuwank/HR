using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Employee: EntityBase
    {
        public Person Person { get; set; }
        [Required]
        [ForeignKey("Person_FK1")]
        public int PersonId { get; set; }
        public EmployeeJob EmployeeJob { get; set; }        
        [Required]
        [ForeignKey("EmployeeJob_FK")]
        public int EmployeeJobId { get; set; }             
        [ForeignKey("Person_FK2")]
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }        
        [ForeignKey("Person_FK3")]
        public int? NomineeId { get; set; }
        public Person Nominee { get; set; }        
        public string PanNumber { get; set; }
        public string CitNumber { get; set; }
       


    }
}
