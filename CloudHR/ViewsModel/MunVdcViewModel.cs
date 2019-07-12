namespace CloudHR.ViewsModel
{
    public class MunVdcViewModel:BaseViewModel
    {
        public string Name { get; set; }       
        public int VdcMunType { get; set; }
        public DistrictViewModel District { get; set; }        
        public int DistrictId { get; set; }       
        public int WardCount { get; set; }
    }
}
