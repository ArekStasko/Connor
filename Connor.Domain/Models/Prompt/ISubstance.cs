namespace Connor.Domain.Models.Prompt;

public interface ISubstance
{
    string Type { get; }
    string Text { get; }
    string Avoid { get; }
    string FocusOn { get; }
}