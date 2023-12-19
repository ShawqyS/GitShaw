using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolTech.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace SchoolTech.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<Gebruiker> userManager;
        private readonly SignInManager<Gebruiker> signInManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(UserManager<Gebruiker> userManager,
            SignInManager<Gebruiker> signInManager, ILogger<HomeController> logger)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _logger = logger;
        }
        //public async Task<IActionResult> Logout()
        //{
        // await signInManager.SignOutAsync();
        //return RedirectToAction("login", "account");
        //}

        public IActionResult Dashboard()
        {
            return View();
        }


        public IActionResult Afwezigheden()
        {
            return View();
        }


        public IActionResult Index()
        {
            return RedirectToAction("Login", "Account", new { Area = "Identity" });
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet, AllowAnonymous]
        public IActionResult Register()
        {
            Gebruiker model = new Gebruiker();
            return View(model);
        }
        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Register(Gebruiker request)
        {
            ModelState.Remove("AangevraagdeNavormingen");
            ModelState.Remove("GebruikerNavormingen");
            ModelState.Remove("AangevraagdeStudiebezoeken");
            ModelState.Remove("Naam");
            ModelState.Remove("Voornaam");
            ModelState.Remove("Initialen");
            ModelState.Remove("Gebruikersnaam");
            ModelState.Remove("BegeleidStudieBezoeken");
            ModelState.Remove("GebruikerRollen");
            ModelState.Remove("Afwezigheden");
            if (ModelState.IsValid)
            {
                var userCheck = await userManager.FindByEmailAsync(request.Email);
                if (userCheck == null)
                {
                    var user = new Gebruiker
                    {
                        UserName = request.Email,
                        NormalizedUserName = request.Email,
                        Email = request.Email,
                        EmailConfirmed = true,
                        Initialen = request.Initialen,
                        Gebruikersnaam = request.Email,
                        Naam = request.Email,
                        Voornaam = request.Email,
                        Wachtwoord = request.Wachtwoord
                    };
                    var result = await userManager.CreateAsync(user, request.Wachtwoord);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, "Gebruiker");
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        if (result.Errors.Count() > 0)
                        {
                            foreach (var error in result.Errors)
                            {
                                ModelState.AddModelError("message", error.Description);
                            }
                        }
                        return View(request);
                    }
                }
                else
                {
                    ModelState.AddModelError("message", "Email already exists.");
                    return View(request);
                }
            }
            return View(request);

        }
    }
}