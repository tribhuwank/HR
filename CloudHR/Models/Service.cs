using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Service: EntityBase
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public bool Status { get; set; }
        [ForeignKey("Service_FK")]
        public int? ParentServiceId { get; set; }

    }
}
