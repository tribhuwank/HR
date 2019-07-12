namespace CloudHR.ViewsModel
{
    public class LevelViewModel:BaseViewModel
    {
        public string Name { get; set; }
        public int PayGradeId { get; set; }
        public decimal GradePerMonth { get; set; }
        public int? GradeUpgradationMonth { get; set; }
        public decimal GradeUpgradationRate { get; set; }
        public decimal MaxGradeValue { get; set; }
        public bool IsActive { get; set; }

    }
}
