using blogBonito.Models;
using Microsoft.AspNetCore.Mvc;

namespace blogBonito.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Index(int id)
        {
            nubeContext db = new nubeContext();
            var libro = db.Libros.Where(w=>w.Id==id).FirstOrDefault();
            return View(libro);
        }
    }
}
