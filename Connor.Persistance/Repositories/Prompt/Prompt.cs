using Connor.Domain.Models.Prompt;

namespace Connor.Persistance.Repositories.Prompt;

public class Prompt : IPrompt
{
    public Task<ISubstance> GetSubstance(string substanceId)
    {
        throw new NotImplementedException();
    }

    public Task<ITimePeriod> GetTimePeriod(string timePeriodId)
    {
        throw new NotImplementedException();
    }
}