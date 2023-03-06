using AppAgendamentos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppAgendamentos.Infrastructure.Configuration
{
    public class SchedulingConfiguration : IEntityTypeConfiguration<Scheduling>
    {
        public void Configure(EntityTypeBuilder<Scheduling> builder)
        {
            builder.ToTable("schedulings");

            builder.Property(c=>c.Company)
                .HasColumnName("company_id")
                .IsRequired();

            builder.Property(c=>c.Customer)
                .HasColumnName("customer_id")
                .IsRequired();
                
            builder.Property(c=>c.ScheduledDate).IsRequired();
        }
    }
}