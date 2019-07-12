using System;

namespace CloudHR.ViewsModel
{
    public class OfficeViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public AddressViewModel Address { get; set; }
        public int AddressId { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string Fax { get; set; }
        public string Logo { get; set; }
        
    }
}
