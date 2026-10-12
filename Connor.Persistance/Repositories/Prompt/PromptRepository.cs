using Connor.Domain.Models.Prompt;
using Microsoft.EntityFrameworkCore;

namespace Connor.Persistance.Repositories.Prompt;

public class PromptRepository(PersistanceContext context) : IPromptRepository
{
    public async Task<ISubstance?> GetSubstance(int substanceId)
        => await context.Prompts.FirstOrDefaultAsync(p => p.Id == substanceId);

    public async Task<IList<ITimePeriod>> GetTimePeriods()
        => await context.Prompts.ToListAsync<ITimePeriod>();
    public async Task<ITimePeriod?> GetTimePeriod(int timePeriodId)
        => await context.Prompts.FirstOrDefaultAsync(p => p.Id == timePeriodId);
}