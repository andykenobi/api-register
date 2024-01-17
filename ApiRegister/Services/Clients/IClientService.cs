using ApiRegister.DTOs.Clients;

namespace ApiRegister.Services.Clients
{
    public interface IClientService
    {
        Task<GetClientResponse> Get(string id);
        Task<List<GetClientResponse>> GetList();
        Task<string> Create(CreateClientRequest request);
        Task<GetClientResponse> Update(UpdateClientRequest request);
        Task<bool> Delete(string id);
    }
}
