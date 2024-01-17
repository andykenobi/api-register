using System.Net.Http;

namespace ApiRegister.Services
{
    public class ViacepService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public ViacepService() { }

        public async Task<string> GetCep(string cep)
        {
            var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}
