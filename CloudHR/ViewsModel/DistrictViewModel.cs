namespace CloudHR.ViewsModel
{
    public class DistrictViewModel:BaseViewModel
    {
        public string Name { get; set; }
        public int ProvinceId { get; set; }
        public ProvinceViewModel Province { get; set; }
    }
}
