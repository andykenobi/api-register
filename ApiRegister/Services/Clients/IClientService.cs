using ApiRegister.DTOs;
using ApiRegister.DTOs.Clients;

namespace ApiRegister.Services.Clients
{
    public interface IClientService
    {
        Task<Response<GetClientResponse>> Get(long id);
        Task<Response<List<GetClientResponse>>> GetList();
        Task<Response<string>> Create(CreateClientRequest request);
        Task<Response<GetClientResponse>> Update(UpdateClientRequest request);
        Task<Response<bool>> Delete(long id);
    }
}
