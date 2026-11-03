using Connor.Domain.Models.Receiver;

namespace Connor.Persistance.Repositories.Receiver;

public interface IReceiverRepository
{
    public Task<IPersonality?> GetPersonality();
    public Task<IProfile?> GetProfile();
}