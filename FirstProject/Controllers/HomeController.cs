using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            string name = "Biswadeep";
            return View("MyView", name);
        }
    }
}
