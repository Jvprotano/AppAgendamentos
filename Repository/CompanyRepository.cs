using AppAgendamentos.Contracts.Repository;
using AppAgendamentos.Infrastructure;
using AppAgendamentos.Models;

namespace AppAgendamentos.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Save(Company company)
        {
            try
            {
                await _context.Companies.AddAsync(company);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}