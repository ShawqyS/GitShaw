using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolTech.Controllers
{
    public class FotoalbumController : Controller
    {
        public IActionResult Toevoegen()
        {
            return View();
        }

        public IActionResult Weergeven()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bewerken()
        {
            return View();
        }
    }
}
