using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Person : EntityBase
    {
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime? DOB { get; set; }
        [Required]
        [ForeignKey("Gender_FK")]
        public int? GenderId { get; set; }      
        [ForeignKey("Religion_FK")]
        public int? ReligionId { get; set; }    
        [ForeignKey("Cast_FK")]
        public int? CastId { get; set; }     
        public string Email { get; set; }       
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }      
        [ForeignKey("Address_FK1")]
        public int? PermanentAddressId { get; set; }      
        [ForeignKey("Address_FK2")]
        public int? TemporaryAddressId { get; set; }
        [ForeignKey("MaritalStatus_FK")]
        public int? MaritalStatusId { get; set; }     
        [ForeignKey("HealthStatus_FK")]
        public int? HealthStatusId { get; set; }
        public byte[] Photo { get; set; }      
        [ForeignKey("IdentityType_FK")]
        public int? IdentityTypeId { get; set; }       
        public string IdentityNumber { get; set; }       
        public DateTime? IdentityIssueData { get; set; }     
        public string IdentityIssuePlace { get; set; }       
        [ForeignKey("Litracy_FK")]
        public int? LitracyId { get; set; }         
        [ForeignKey("EduInstutionType_FK")]
        public int? EduInstutionTypeId { get; set; }     
        [ForeignKey("Relation_FK")]
        public int? RelationId { get; set; }
        
    }
}
