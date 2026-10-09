using Connor.Domain.Models.Connor;

namespace Connor.Persistance.Repositories.Connor;

public interface IConnor
{
    public Task<IConfiguration> GetConfiguration();
}