namespace Blazor.Services
{
    public class GetValueServices : IGetValue
    {
        public HttpClient _httpClient;
        public GetValueServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetValue(string token)
        {
            _httpClient.DefaultRequestHeaders.Add("token", token);
            var result = await _httpClient.GetStringAsync("http://14.241.182.251:61532/api/medical/document/eyJlbmNvdW50ZXIiOiIyMzAwMDAzOSJ9");
            return result;
        }
    }
}
