using Connor.Domain.Models.Receiver;
using Microsoft.EntityFrameworkCore;

namespace Connor.Persistance.Repositories.Receiver;

public class Receiver(PersistanceContext context) : IReceiver
{
    
    public async Task<IPersonality?> GetPersonality()
        => await context.Receivers.FirstOrDefaultAsync();

    public async Task<IProfile?> GetProfile()
        => await context.Receivers.FirstOrDefaultAsync();
}