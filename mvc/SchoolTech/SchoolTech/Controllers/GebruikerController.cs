using Microsoft.AspNetCore.Mvc;
using SchoolTech.Data.Repository;
using SchoolTech.Data.UnitOfWork;
using SchoolTech.Models;
using SchoolTech.ViewModels;

namespace SchoolTech.Controllers
{
    public class GebruikerController : Controller
    {
        private readonly IUnitOfWork _uow;

        public GebruikerController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public IActionResult Toevoegen()
        {
            return View();
        }

        public async Task<IActionResult> CRUD()
        {
            GebruikerCRUDViewModel vm = new GebruikerCRUDViewModel();
            var gebruikers = await _uow.GebruikerRepository.GetAllAsync();
            vm.Gebruikers = gebruikers.ToList();

            return View(vm);
        }

        public IActionResult Aanpassen()
        {
            return View();
        }
    }
}