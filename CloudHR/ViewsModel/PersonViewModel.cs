using System;

namespace CloudHR.ViewsModel
{
    public class PersonViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? DOB { get; set; }
        public GenderViewModel Gender { get; set; }
        public int? GenderId { get; set; }
        public int? ReligionId { get; set; }
        public ReligionViewModel Religion { get; set; }
        public int? CastId { get; set; }
        public CastViewModel Cast { get; set; }
        public string Email { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public AddressViewModel PermanentAddress { get; set; }
        public int? PermanentAddressId { get; set; }
        public AddressViewModel TemporaryAddress { get; set; }
        public int? TemporaryAddressId { get; set; }
        public MaritalStatusViewModel MaritalStatus { get; set; }
        public int? MaritalStatusId { get; set; }
        public HealthStatusViewModel HealthStatus { get; set; }
        public int? HealthStatusId { get; set; }
        public string Photo { get; set; }
        public IdentityTypeViewModel IdentityType { get; set; }
        public int? IdentityTypeId { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime? IdentityIssueData { get; set; }
        public string IdentityIssuePlace { get; set; }
        public int? LitracyId { get; set; }
        public LitracyViewModel Litracy { get; set; }       
        public int? EduInstutionTypeId { get; set; }
        public EduInstutionTypeViewModel EduInstutionType { get; set; }
        public int? RelationId { get; set; }
        public RelationViewModel Relation { get; set; }
       
    }
}
