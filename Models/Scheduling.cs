using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppAgendamentos.Models.Base;

namespace AppAgendamentos.Models
{
    public class Scheduling : BaseEntity
    {
        public int CompanyId { get; set; }
        public Company? Company { get; set; }
        
        public int CustomerId { get; set; }
        public User Customer { get; set; }

        public DateTime ScheduledDate { get; set; }
    }
}