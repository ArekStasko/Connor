namespace Connor.Services.Services;

public class ConnorService : IConnorService
{
    public async Task<string> GetSentece()
    {
        await Task.Delay(5000);
        throw new NotImplementedException();
    }
}