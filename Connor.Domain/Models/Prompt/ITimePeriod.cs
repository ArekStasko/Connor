namespace Connor.Domain.Models.Prompt;

public interface ITimePeriod : IIdentity
{
    TimeOnly From { get; }
    TimeOnly To { get; }
}