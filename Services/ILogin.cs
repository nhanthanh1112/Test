namespace Blazor.Services
{
    public interface ILogin
    {
        Task<string> Login(string username, string password);
    }
}
