using ApiRegister.DTOs;
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

        public async Task<Response<GetClientResponse>> Get(long id)
        {
            var response = new Response<GetClientResponse>();

            var result = await _repository.Get(id);

            if (result == null)
                response.Errors.Add("Id not Found.");
            else
                response.Value = _mapper.Map<GetClientResponse>(result);

            return response;
        }

        public async Task<Response<List<GetClientResponse>>> GetList()
        {
            var response = new Response<List<GetClientResponse>>();

            var clients = await _repository.GetList();
            response.Value = _mapper.Map<List<GetClientResponse>>(clients);

            return response;
        }

        public async Task<Response<string>> Create(CreateClientRequest request)
        {
            var response = new Response<String>();

            if (!await ValidateCEP(request.Cep))
            {
                response.Errors.Add("Cep not valid.");
                return response;
            }

            var client = _mapper.Map<Client>(request);
            response.Value = await _repository.Create(client);

            return response;
        }

        public async Task<Response<GetClientResponse>> Update(UpdateClientRequest request)
        {
            var response = new Response<GetClientResponse>();

            if (!await ValidateCEP(request.Cep))
            {
                response.Errors.Add("Cep not valid.");
                return response;
            }

            var client = _mapper.Map<Client>(request);
            var result = await _repository.Update(client);


            if (result == null)
                response.Errors.Add("Id not Found.");
            else
                response.Value = _mapper.Map<GetClientResponse>(result);

            return response;
        }

        public async Task<bool> Delete(long id)
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
