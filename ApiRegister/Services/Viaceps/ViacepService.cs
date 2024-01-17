using System.Net.Http;

namespace ApiRegister.Services.Viaceps
{
    public class ViacepService : IViacepService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public ViacepService() { }

        public async Task<bool> Validate(string cep)
        {
            var response = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            var result = response.IsSuccessStatusCode;

            return result;
        }
    }
}
