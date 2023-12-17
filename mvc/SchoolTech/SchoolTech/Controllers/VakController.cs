using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolTech.Data.UnitOfWork;
using SchoolTech.Models;
using SchoolTech.ViewModels;

namespace SchoolTech.Controllers
{
    // vak property "IsVerwijderd" is misschien nutteloos en zou alter verwijderd moeten worden
    [Authorize(Roles = "Admin,Coordinator")]
    public class VakController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public VakController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Toevoegen()
        {
            VakCreateViewModel vm = new VakCreateViewModel();
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Toevoegen(VakCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                await _unitOfWork.VakRepository.AddAsync(new Vak()
                {
                    Naam = viewModel.Naam,
                    Verwijderd = false,
                }) ;
                _unitOfWork.SaveChanges();
                return RedirectToAction("CRUD", "Vak");
            }
            VakCreateViewModel vm = new VakCreateViewModel();
            return View(vm);
        }
        public async Task<IActionResult> CRUD()
        {
            VakCRUDViewModel vakken = new VakCRUDViewModel();
            var vakList = await _unitOfWork.VakRepository.GetAllAsync();
            vakken.Vakken = (List<Vak>)vakList;

            return View(vakken);
        }

        public async Task<IActionResult> Aanpassen(int id)
        {
            var bestaandeVak = await _unitOfWork.VakRepository.GetByIdAsync(id);

            if (bestaandeVak == null)
            {
                return NotFound();
            }

            var viewModel = new VakUpdateViewModel
            {
                VakId = bestaandeVak.VakId,
                Naam = bestaandeVak.Naam,
            };

            if (HttpContext.Request.Method == "POST")
            {
                bestaandeVak.Naam = HttpContext.Request.Form["Naam"];
                _unitOfWork.SaveChanges();
                return RedirectToAction("CRUD");
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var vak = await _unitOfWork.VakRepository.GetByIdAsync(id);

            if (vak == null)
            {
                return NotFound();
            }

            _unitOfWork.VakRepository.Delete(vak);
            _unitOfWork.SaveChanges();

            return RedirectToAction("CRUD");
        }
    }
}
