using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolTech.Controllers
{
    [Authorize(Roles = "Gebruiker,Admin,Coordinator,Directie,Medewerker,Leerkracht")]
    public class StudiebezoekController : Controller
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

        public IActionResult Archief()
        {
            return View();
        }
    }
}
