using System.Text.Json;

namespace ApiRegister.Services.Viaceps
{
    public class ViacepService : IViacepService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public ViacepService() { }

        public async Task<bool> Validate(string cep)
        {
            var viacepResponse = await _httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

            if(!viacepResponse.IsSuccessStatusCode)
            {
                return false;
            }

            // Como não tem um padrão de resposta quando o cep esta errado ou invalido (Exemplo: Retorna 400 quando o cep esta em formato invalido
            // e retorna 200 com uma propriedade de 'erro' quando o cep nao foi encontrado ou não existe.) foi efetuado uma solução desta forma.
            if (viacepResponse.IsSuccessStatusCode)
            {
                var stringResponse = await viacepResponse.Content.ReadAsStringAsync();
                var dynamicObject = System.Text.Json.JsonDocument.Parse(stringResponse);
                System.Text.Json.JsonElement dynamicProperty;

                dynamicObject.RootElement.TryGetProperty("erro", out dynamicProperty);
                if (dynamicProperty.ValueKind == JsonValueKind.True || dynamicProperty.ValueKind == JsonValueKind.False)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
