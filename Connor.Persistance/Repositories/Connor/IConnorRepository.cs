using Connor.Domain.Models.Connor;

namespace Connor.Persistance.Repositories.Connor;

public interface IConnorRepository
{
    public Task<IConfiguration?> GetConfiguration();
}