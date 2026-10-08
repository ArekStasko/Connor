using Connor.Domain.Models.Prompt;

namespace Connor.Persistance.Models;

public class Prompt : ISubstance, ITimePeriod
{
    public int Id { get; set; }
    public string Type { get; }
    public string Text { get; }
    public string Avoid { get; }
    public string FocusOn { get; }
    public TimeOnly From { get; }
    public TimeOnly To { get; }
}