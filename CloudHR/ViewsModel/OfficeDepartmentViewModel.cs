namespace CloudHR.ViewsModel
{
    public class OfficeDepartmentViewModel:BaseViewModel
    {
        public int DepartmentId { get; set; }
        public DepartmentViewModel Department { get; set; }       
        public int OfficeId { get; set; }
        public OfficeViewModel Office { get; set; }       
        public bool Status { get; set; }
    }
}
