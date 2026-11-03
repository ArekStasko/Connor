using Connor.Domain.Models.Connor;
using Microsoft.EntityFrameworkCore;

namespace Connor.Persistance.Repositories.Connor;

public class ConnorRepository(PersistanceContext context) : IConnorRepository
{
    public async Task<IConfiguration?> GetConfiguration()
        => await context.Connors.FirstOrDefaultAsync();
}