using CloudHR.Models;
using System.Collections.Generic;

namespace CloudHR.ViewsModel
{
    public class QualificationViewModel: BaseViewModel
    {
        public int PersonId { get; set; }
        public PersonViewModel Person { get; set; }
        public Skill[] Skills { get; set; }
        public PersonEducationViewModel[] PersonEducation { get; set; }
        public Language[] Languages { get; set; }
        public IList<string> Attachements { get; set; }
    }
}
