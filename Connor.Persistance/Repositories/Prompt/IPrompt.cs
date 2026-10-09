using Connor.Domain.Models.Prompt;

namespace Connor.Persistance.Repositories.Prompt;

public interface IPrompt
{
    public Task<ISubstance> GetSubstance(string substanceId);
    public Task<ITimePeriod> GetTimePeriod(string timePeriodId);
}