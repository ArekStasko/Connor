using Connor.Domain.Models.Receiver;

namespace Connor.Persistance.Repositories.Receiver;

public interface IReceiver
{
    public Task<IPersonality> GetPersonality();
    public Task<IProfile> GetProfile();
}