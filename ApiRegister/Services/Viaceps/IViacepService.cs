using ApiRegister.DTOs;

namespace ApiRegister.Services.Viaceps
{
    public interface IViacepService
    {
        Task<bool> Validate(string cep);
    }
}
