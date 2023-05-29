using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Introduction.Controllers
{

    public class UserController : Controller 
    {
        public ViewResult Index()
        {
            @ViewBag.Name = "Fatima";
            @ViewBag.Surname = "Karimova";
            @ViewBag.Age = 25;
            @ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = 0773000416;
            return View();
        }
    }
}
