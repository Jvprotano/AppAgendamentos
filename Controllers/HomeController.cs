using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AppAgendamentos.Models;
using AppAgendamentos.Contracts.Repository;
using AppAgendamentos.Repository;

namespace AppAgendamentos.Controllers;

public class HomeController : Controller
{
    private readonly ICompanyRepository _companyRepository;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, ICompanyRepository companyRepository)
    {
        _logger = logger;
        _companyRepository = companyRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreateCompany()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateCompany(Company company)
    {
        _companyRepository.Save(company);

        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
