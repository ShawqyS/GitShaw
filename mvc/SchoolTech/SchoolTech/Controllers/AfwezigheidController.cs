using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SchoolTech.Controllers
{
    [Authorize(Roles = "Admin,Medewerker,Leerkracht,Coordinator")]
    public class AfwezigheidController : Controller
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
