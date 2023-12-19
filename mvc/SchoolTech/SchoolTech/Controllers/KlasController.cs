using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolTech.Controllers
{
    [Authorize(Roles = "Admin,Coordinator")]
    public class KlasController : Controller
    {
        public IActionResult Toevoegen()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Aanpassen()
        {
            return View();
        }
    }
}
