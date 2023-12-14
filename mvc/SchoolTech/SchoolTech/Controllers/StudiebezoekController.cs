using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolTech.Controllers
{
    public class StudiebezoekController : Controller
    {
        //[Authorize(Roles = "Gebruiker,Admin,Coordinator,Directie,Medewerker,Leerkracht")]
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

        public IActionResult Archief()
        {
            return View();
        }
    }
}
