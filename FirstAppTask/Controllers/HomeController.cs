using Microsoft.AspNetCore.Mvc;

namespace FirstAppTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
