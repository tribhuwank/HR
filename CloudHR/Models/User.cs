
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class User : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [ForeignKey("Role_FK")]
        public int RoleId { get; set; }
        [ForeignKey("Person_FK")]
        public int? PersonId { get; set; }

    }
}
