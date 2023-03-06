using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppAgendamentos.Models.Base;

namespace AppAgendamentos.Models
{
    [Table("companies")]
    public class Company : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        [ForeignKey("User")]
        public int UserId { get; set; }

        public User Owner { get; set; }
    }
}