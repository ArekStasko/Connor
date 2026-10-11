using Connor.Domain.Models.Connor;
using Microsoft.EntityFrameworkCore;

namespace Connor.Persistance.Repositories.Connor;

public class Connor(PersistanceContext context) : IConnor
{
    public async Task<IConfiguration?> GetConfiguration()
        => await context.Connors.FirstOrDefaultAsync();
}