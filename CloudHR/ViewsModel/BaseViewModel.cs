using System;

namespace CloudHR.ViewsModel
{
    public abstract class BaseViewModel
    {
        public int? Id { get; set; }
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public DateTime? DateCreated { get; set; }
        public string UserCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string UserModified { get; set; }
    }
}
