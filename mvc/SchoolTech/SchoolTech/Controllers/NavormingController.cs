using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using SchoolTech.Data.UnitOfWork;
using SchoolTech.ViewModels;
using SchoolTech.Models;
using System.Drawing;
using System.Net;

namespace SchoolTech.Controllers
{
    public class NavormingController : Controller
    {
        private readonly IUnitOfWork _uow;

        public NavormingController(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<IActionResult> Toevoegen()
        {
            NavormingCreateViewModel vm = new NavormingCreateViewModel();
            vm.Gebruikers = await _uow.GebruikerRepository.GetAllAsync();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Toevoegen(NavormingCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _uow.NavormingRepository.AddAsync(new Navorming()
                {
                    Datum = viewModel.Datum,
                    StartUur = viewModel.StartUur,
                    EindUur = viewModel.EindUur,
                    Reden = viewModel.Reden,
                    Kostprijs = viewModel.Kostprijs,
                    IsGoedgekeurdDir = viewModel.IsGoedgekeurdDir,
                    isAfgewezen = viewModel.isAfgewezen,
                    OpmerkingAfgewezen = viewModel.OpmerkingAfgewezen,
                    IsAfgewerkt = viewModel.IsAfgewerkt,
                    GebruikerId = viewModel.GebruikerId.ToString()
                });
                _uow.SaveChanges();
                return RedirectToAction("CRUD", "Navorming");
            }
            NavormingCreateViewModel vm = new NavormingCreateViewModel();
            vm.Gebruikers = await _uow.GebruikerRepository.GetAllAsync();
            return View(vm);
        }

        public async Task<IActionResult> CRUD()
        {
            NavormingCRUDViewModel vm = new NavormingCRUDViewModel();
            var navormingen = _uow.NavormingRepository.Search()
                .Include(b => b.Aanvrager)
                .Include(b => b.GebruikerNavormingen)
                    .ThenInclude(c => c.Gebruiker);
            vm.Navormingen = navormingen.ToList();

            return View(vm);
        }

        public IActionResult Aanpassen()
        {
            return View();
        }
    }
}