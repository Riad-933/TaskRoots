using Microsoft.AspNetCore.Mvc;

namespace FirstAppTask.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
