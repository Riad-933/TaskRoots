using Microsoft.AspNetCore.Mvc;

namespace FirstAppTask.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
