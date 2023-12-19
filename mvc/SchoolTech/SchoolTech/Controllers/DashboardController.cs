using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolTech.Data.UnitOfWork;

[Authorize(Roles = "Gebruiker,Admin,Coordinator,Directie,Medewerker,Leerkracht")]
public class DashboardController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public DashboardController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> Index()
    {
        var studieaanvragen = await _unitOfWork.StudiebezoekRepository.GetAllAsync();
        var afwezigheden = await _unitOfWork.AfwezigheidRepository.GetAllAsync();
        var navormingen = await _unitOfWork.NavormingRepository.GetAllAsync();
        var gebruikers = await _unitOfWork.GebruikerRepository.GetAllAsync();
        var klassen = await _unitOfWork.KlasRepository.GetAllAsync();
        var fotoalbums = await _unitOfWork.FotoalbumRepository.GetAllAsync();

        ViewBag.StudieaanvragenCount = studieaanvragen.Count();
        ViewBag.AfwezigheidCount = afwezigheden.Count();
        ViewBag.NavormingenCount = navormingen.Count();
        ViewBag.GebruikersCount = gebruikers.Count();
        ViewBag.KlasCount = klassen.Count();
        ViewBag.FotoalbumCount = fotoalbums.Count();

        return View();
    }
}
