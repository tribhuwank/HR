using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CloudHR.Models
{
    public class Office: EntityBase
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [ForeignKey("Address_FK")]
        public int AddressId { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        [Required]
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        [Required]
        public string Fax { get; set; }
        public byte[] Logo { get; set; }
        public string Remarks { get; set; }
        [Required]
        public int EntryBy { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }
        [Required]
        public int UpdateBy { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }

    }
}
