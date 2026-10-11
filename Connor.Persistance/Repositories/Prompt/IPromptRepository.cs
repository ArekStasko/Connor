using Connor.Domain.Models.Prompt;

namespace Connor.Persistance.Repositories.Prompt;

public interface IPromptRepository
{
    public Task<ISubstance?> GetSubstance(int substanceId);
    public Task<IList<ITimePeriod>> GetTimePeriods();
    public Task<ITimePeriod?> GetTimePeriod(int timePeriodId);
}