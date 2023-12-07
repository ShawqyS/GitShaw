using Microsoft.AspNetCore.Mvc;

namespace SchoolTech.Controllers
{
    public class VakController : Controller
    {
        public IActionResult Toevoegen()
        {
            return View();
        }

        public IActionResult CRUD()
        {
            return View();
        }

        public IActionResult Aanpassen()
        {
            return View();
        }
    }
}
