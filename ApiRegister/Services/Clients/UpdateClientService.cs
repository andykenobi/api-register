using ApiRegister.DTOs.Clients;
using ApiRegister.Repositories.Clients;

namespace ApiRegister.Services.Clients
{
    public class UpdateClientService
    {
        private ViacepService _viacepService;
        private UpdateClientRepository _repository;

        public UpdateClientService(ViacepService viacepService, UpdateClientRepository repository)
        {
            _viacepService = viacepService;
            _repository = repository;
        }

        public async Task<GetClientResponse> Update(UpdateClientRequest request)
        {
            return null;
        }
    }
}
