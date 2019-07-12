using CloudHR.Models;
using System;

namespace CloudHR.ViewsModel
{
    public class PersonEducationViewModel : BaseViewModel
    {
        public int EducationId { get; set; }
        public Education Education { get; set; }       
        public string Level { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDateDate { get; set; }
        public string Institution { get; set; }
        public string InstitutionAddress { get; set; }
    }
}
