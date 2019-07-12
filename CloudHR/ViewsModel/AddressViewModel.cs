using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudHR.ViewsModel
{
    public class AddressViewModel: BaseViewModel
    {
        public int? AddressTypeId { get; set; }
        public AddressTypeViewModel AddressType { get; set; }
        public int? CountryId { get; set; } = 1;
        public CountryViewModel Country { get; set; }
        public ProvinceViewModel Province { get; set; }
        public int? ProvinceId { get; set; } 
        public DistrictViewModel District { get; set; }
        public int? DistrictId { get; set; } 
        public MunVdcViewModel MunVdc { get; set; }
        public int? MunVdcId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string WardNo { get; set; }
        public string PinCode { get; set; }
        public string HouseNo { get; set; }
    }
}
