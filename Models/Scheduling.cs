using AppAgendamentos.Models.Base;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppAgendamentos.Models
{
    public class Scheduling : BaseEntity
    {
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        public int CustomerId { get; set; }
        public User? Customer { get; set; }
        public DateTime ScheduledDate { get; set; }
    }
}