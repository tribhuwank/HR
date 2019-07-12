

namespace CloudHR.ViewsModel
{
    public class LoginViewModel: BaseViewModel
    {       
        public string Username { get; set; }        
        public string Password { get; set; }
        public LoginViewModel()
        {
            ErrorMessage = "";
        }
    }
}
