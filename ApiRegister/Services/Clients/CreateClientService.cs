using ApiRegister.DTOs.Clients;
using ApiRegister.Repositories.Clients;

namespace ApiRegister.Services.Clients
{
    public class CreateClientService
    {
        private ViacepService _viacepService;
        private CreateClientRepository _repository;

        public CreateClientService(ViacepService viacepService, CreateClientRepository repository)
        {
            _viacepService = viacepService;
            _repository = repository;
        }

        public async Task<string> Create(CreateClientRequest request)
        {
            return null;
        }
    }
}
