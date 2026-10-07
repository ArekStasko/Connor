namespace Connor.Domain.Models.Prompt;

public interface ITimePeriod
{
    TimeOnly From { get; }
    TimeOnly To { get; }
}