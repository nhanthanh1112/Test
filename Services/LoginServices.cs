using System.Net.Http.Json;
using System.Text.Json;
namespace Blazor.Services
{
    public class LoginServices : ILogin
    {
        public HttpClient _httpClient;
        public LoginServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> Login(string username, string password)
        {
            var rd_key = "i3uJU1ms+3Sj+2sUtQN2GyqT8gvpHwTLcpnCRDAybQclD8XVQiowmglOtz+PKuY1/Bj6yBgnJzozFhcOLgM6DoKd3rmcZXfJN1QQ+/AoA0/BcElT++FDpmoK1UyirKooNUb33+u1NjhpOIY/o1XXHfU12MK8SW5Y+wR8xbLMvksjgx35bqkDBSeHc1aC2uWDvyu8S7NoGXOOhvrqzdl1XAbWBppXCToPfg/54Lff2XLovSxvOKHzwWjDu4Z9KP4W5VbdDl9WZi7g7Df+5jw7zmnkHqB5oyWlBxTF0HK0nilRn5FN5k1s0LfMIJstuS8Lk5s64ORyLD10hqfD0M6POQ==";
            _httpClient.DefaultRequestHeaders.Add("user", username);
            _httpClient.DefaultRequestHeaders.Add("password", password);
            _httpClient.DefaultRequestHeaders.Add("rd_key", rd_key);
            var result = await _httpClient.GetStringAsync("http://14.241.182.251:61532/api/user/rdparty/login");
            return result;
        }
    }
}
