using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppAgendamentos.ViewModels
{
    public class SchedulingViewModel
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public int CustomerId { get; set; }

        public IEnumerable<SelectListItem>? ListaTeste { get; set; }

        public DateTime ScheduledDate { get; set; }


        public SchedulingViewModel()
        {
            CompanyName = String.Empty;
            ListaTeste = new List<SelectListItem>();
        }
    }
}