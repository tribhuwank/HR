namespace CloudHR.ViewsModel
{
    public class RoleViewModel:BaseViewModel
    {       
        public string Name { get; set; }

       public RoleViewModel()
        {
            ErrorMessage = "";
        }
    }
}
