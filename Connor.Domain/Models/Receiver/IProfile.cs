namespace Connor.Domain.Models.Receiver;

public interface IProfile
{
    string Name { get; }
    string Surname { get; }
    byte Age { get; }
    bool Gender { get; }
    string Profession { get; }
}