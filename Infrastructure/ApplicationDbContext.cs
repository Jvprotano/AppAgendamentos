using AppAgendamentos.Infrastructure.Extensions;
using AppAgendamentos.Models;
using AppAgendamentos.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace AppAgendamentos.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Company>? Companies { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Scheduling>? Schedulings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplySnakeCaseNamingConvention();

            // modelBuilder.ApplyConfiguration(new SchedulingConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            AtualizarDatas();
            return base.SaveChanges();
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AtualizarDatas();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void AtualizarDatas()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (
                e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var entity = (BaseEntity)entry.Entity;
                var now = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.RegisterDate = now;
                }

                entity.UpdateDate = now;
            }
        }

    }
}