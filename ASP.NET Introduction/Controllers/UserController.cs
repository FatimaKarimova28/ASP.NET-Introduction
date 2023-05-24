using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Introduction.Controllers
{

    public class UserController : Controller 
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
