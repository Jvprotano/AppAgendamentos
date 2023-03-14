using AppAgendamentos.Contracts.Repository;
using AppAgendamentos.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppAgendamentos.Controllers
{
    // [Route("[controller]")]
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(ILogger<CompanyController> logger, ICompanyRepository companyRepository)
        {
            _logger = logger;
            _companyRepository = companyRepository;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Create");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Company company)
        {
            await _companyRepository.Save(company);

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}