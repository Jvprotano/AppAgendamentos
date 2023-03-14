using AppAgendamentos.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AppAgendamentos.Controllers
{
    // [Route("[controller]")]
    public class SchedulingController : Controller
    {
        private readonly ILogger<SchedulingController> _logger;

        public SchedulingController(ILogger<SchedulingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Create()
        {
            SchedulingViewModel model = new SchedulingViewModel();

            return View(model);
        }
    }
}