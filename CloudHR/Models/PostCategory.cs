using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class PostCategory: EntityBase
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("PostCategory_FK")]
        public int? PostCategoryId { get; set; }
       
    }
}
