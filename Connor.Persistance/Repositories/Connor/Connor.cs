using Connor.Domain.Models.Connor;

namespace Connor.Persistance.Repositories.Connor;

public class Connor : IConnor
{
    public Task<IConfiguration> GetConfiguration()
    {
        throw new NotImplementedException();
    }
}