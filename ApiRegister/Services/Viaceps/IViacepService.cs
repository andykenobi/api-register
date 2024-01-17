using ApiRegister.DTOs;

namespace ApiRegister.Services.Viaceps
{
    public interface IViacepService
    {
        Task<Response<bool>> Validate(string cep);
    }
}
