using System;

namespace CloudHR.ViewsModel
{
    public class EmployeeJobViewModel:BaseViewModel
    {

        public int? OfficeDepartmentId { get; set; }
        public OfficeDepartmentViewModel OfficeDepartment { get; set; }
        public int? PostId { get; set; }
        public PostViewModel Post { get; set; }
        public DateTime HiringDate { get; set; }
        public string SymbolNumber { get; set; }
        public DateTime? ProbationPeriodFrom { get; set; }
        public DateTime? ProbationPeriodTo { get; set; }
        public string ProbationPermorfanceSummary { get; set; }
        public string OpinionSuggestion { get; set; }
    }
}
