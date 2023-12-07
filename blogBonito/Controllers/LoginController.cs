using Microsoft.AspNetCore.Mvc;

namespace blogBonito.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
