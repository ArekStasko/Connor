using Connor.Domain.Models.Connor;

namespace Connor.Persistance.Models;

public class Connor : IConfiguration
{
    public int Id { get; set; }
    public string Character { get; }
    public string CharacterReference { get; }
}