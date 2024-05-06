using Microsoft.AspNetCore.Mvc;

namespace FirstAppTask.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
