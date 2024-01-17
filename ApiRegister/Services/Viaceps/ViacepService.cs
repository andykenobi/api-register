using ApiRegister.DTOs;
using System.Net.Http;

namespace ApiRegister.Services.Viaceps
{
    public class ViacepService : IViacepService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public ViacepService() { }

        public async Task<Response<bool>> Validate(string cep)
        {
            var response = new Response<bool>();
            
            var viacepResponse = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            
            response.Value = viacepResponse.IsSuccessStatusCode;

            return response;
        }
    }
}
