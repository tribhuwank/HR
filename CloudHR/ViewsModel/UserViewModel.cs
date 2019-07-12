
namespace CloudHR.ViewsModel
{
    public class UserViewModel:BaseViewModel
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public int? PersonId { get; set; }

        public RoleViewModel Role { get; set; }
        public PersonViewModel Person { get; set; }
       
    }
}
