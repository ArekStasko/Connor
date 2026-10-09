namespace Connor.Domain.Models.Receiver;

public interface IPersonality : IIdentity
{
    string Characteristics { get; }
    string Hobbies { get; }
    string Habits { get; }
}