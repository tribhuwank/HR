using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Post: EntityBase
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [ForeignKey("PostCategory_FK1")]
        public int PostCategoryId { get; set; }        
        [Required]
        public bool Status { get; set; }
        [Required]
        [ForeignKey("Level_FK")]
        public int LevelId { get; set; }
        [Required]
        [ForeignKey("Service_FK")]
        public int ServiceId { get; set; }
        [Required]
        [ForeignKey("WorkType_FK")]
        public int WorkTypeId { get; set; }
        [ForeignKey("Department_FK1")]
        public int? DepartmentId { get; set; }        

    }
}
