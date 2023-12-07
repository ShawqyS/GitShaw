using Microsoft.AspNetCore.Mvc;

namespace SchoolTech.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
