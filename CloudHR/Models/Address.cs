using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudHR.Models
{
    public class Address:EntityBase
    {       
        
        [Required]
        [ForeignKey("AddressType_FK")]
        public int? AddressTypeId { get; set; }
        public AddressType AddressType { get; set; }
        [Required]
        [ForeignKey("Country_FK")]
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public Province Province { get; set; }
        [Required]
        [ForeignKey("Province_FK")]
        public int? ProvinceId { get; set; }
        public District District { get; set; }
        [Required]
        [ForeignKey("District_FK")]
        public int? DistrictId { get; set; }
        public MunVdc MunVdc { get; set; }
        [Required]
        [ForeignKey("MunVdc_FK")]
        public int? MunVdcId { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string WardNo { get; set; }
        public string  PinCode { get; set; }
        public string HouseNo { get; set; }
        
    }
}
