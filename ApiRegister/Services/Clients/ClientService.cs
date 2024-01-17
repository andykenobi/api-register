using ApiRegister.DTOs.Clients;
using ApiRegister.Models;
using ApiRegister.Repositories.Clients;
using ApiRegister.Services.Viaceps;
using AutoMapper;

namespace ApiRegister.Services.Clients
{
    public class ClientService : IClientService
    {
        private IViacepService _viacepService;
        private IClientRepository _repository;
        private IMapper _mapper;

        public ClientService(IViacepService viacepService, IClientRepository repository, IMapper mapper)
        {
            _viacepService = viacepService;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetClientResponse> Get(string id)
        {
            var client = await _repository.Get(id);
            var response = _mapper.Map<GetClientResponse>(client);

            return response;
        }

        public async Task<List<GetClientResponse>> GetList()
        {
            var clients = await _repository.GetList();
            var response = _mapper.Map<List<GetClientResponse>>(clients);

            return response;
        }

        public async Task<string> Create(CreateClientRequest request)
        {
            var client = _mapper.Map<Client>(request);
            var id = await _repository.Create(client);

            return id;
        }

        public async Task<GetClientResponse> Update(UpdateClientRequest request)
        {
            var client = _mapper.Map<Client>(request);
            var result = await _repository.Update(client);
            var response = _mapper.Map<GetClientResponse>(client);

            return response;
        }

        public async Task<bool> Delete(string id)
        {
            var result = await _repository.Delete(id);
            return result;
        }

        private async Task<bool> ValidateCEP(string cep)
        {
            var result = await _viacepService.Validate(cep);
            return result;
        }
    }
}
