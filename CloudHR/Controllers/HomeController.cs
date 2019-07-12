using Microsoft.AspNetCore.Mvc;

namespace CloudHR.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
        
    }
}
