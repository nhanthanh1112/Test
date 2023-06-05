namespace Blazor.Services
{
    public interface IGetValue
    {
        Task<string> GetValue(string token);
    }
}
