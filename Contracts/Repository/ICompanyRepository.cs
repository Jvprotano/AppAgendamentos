using AppAgendamentos.Models;

namespace AppAgendamentos.Contracts.Repository
{
    public interface ICompanyRepository
    {
        Task Save(Company company);
    }
}