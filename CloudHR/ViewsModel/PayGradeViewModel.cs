namespace CloudHR.ViewsModel
{
    public class PayGradeViewModel:BaseViewModel
    {
        public string Name { get; set; }       
        public decimal MinSalaryAmount { get; set; }        
        public decimal MaxSalaryAmount { get; set; }       
        public int NumberOfLevels { get; set; }       
        public bool Status { get; set; }
    }
}
