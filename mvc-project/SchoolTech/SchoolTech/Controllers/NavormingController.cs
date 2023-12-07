using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using SchoolTech.Data.UnitOfWork;
using SchoolTech.ViewModels;
using System.Drawing;

namespace SchoolTech.Controllers
{
    public class NavormingController : Controller
    {
        private readonly IUnitOfWork _uow;

        public NavormingController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public IActionResult Toevoegen()
        {
            return View();
        }

        public async Task<IActionResult> CRUD()
        {
            NavormingCRUDViewModel vm = new NavormingCRUDViewModel();
            var navormingen = _uow.NavormingRepository.Search().Include(b => b.Aanvrager);
            vm.Navormingen = navormingen.ToList();

            return View(vm);
        }

        public IActionResult Aanpassen()
        {
            return View();
        }
    }
}