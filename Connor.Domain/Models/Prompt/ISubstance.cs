namespace Connor.Domain.Models.Prompt;

public interface ISubstance
{
    string Text { get; }
    string Avoid { get; }
    string FocusOn { get; }
}