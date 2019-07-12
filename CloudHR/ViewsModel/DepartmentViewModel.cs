namespace CloudHR.ViewsModel
{
    public class DepartmentViewModel: BaseViewModel
    {
        public string Name { get; set; }
        public string DeptNumber { get; set; }
        public string Location { get; set; }       
        public int OfficeId { get; set; }
        public OfficeViewModel Office { get; set; }
    }
}
