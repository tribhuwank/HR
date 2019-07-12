
namespace CloudHR.ViewsModel
{
    public class SalaryViewModel:BaseViewModel
    {
        public int EmployeeId { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public string Year { get; set; }
        public int Month { get; set; }
        public float WorkedDays { get; set; }
        public bool VehicalFacility { get; set; }
        public bool HousingFacility { get; set; }
        public int RemoteArea { get; set; }// 1,2,3,4,5,6
        public decimal BasicSalary { get; set; }
        public decimal GradePerMonth { get; set; }//Automatically come from PostLevel
        public decimal OrgPFContribution { get; set; }
        public decimal AllowancePerMonth { get; set; }//All Other Allowance calculated 
        public decimal DashainAllowance { get; set; }
        public decimal BonusRecieveInYear { get; set; }
        public decimal PfAndCitDeduction { get; set; }
        public decimal LifeInsurenceDeduction { get; set; }
        public decimal HealthInsurenceDeduction { get; set; }
    }
}
