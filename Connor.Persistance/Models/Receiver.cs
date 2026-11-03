using Connor.Domain.Models.Receiver;

namespace Connor.Persistance.Models;

public class Receiver : IProfile, IPersonality
{
    public int Id { get; set; }
    public string Name { get; }
    public string Surname { get; }
    public byte Age { get; }
    public bool Gender { get; }
    public string Profession { get; }
    public string Characteristics { get; }
    public string Hobbies { get; }
    public string Habits { get; }
}