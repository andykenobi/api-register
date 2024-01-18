using ApiRegister.DTOs;
using ApiRegister.DTOs.Clients;
using ApiRegister.Models;
using ApiRegister.Repositories.Clients;
using ApiRegister.Services.Viaceps;
using AutoMapper;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace ApiRegister.Services.Clients
{
    public class ClientService : IClientService
    {
        private IViacepService _viacepService;
        private IClientRepository _repository;
        private IMapper _mapper;
        private IValidator<CreateClientRequest> _createClientValidator;
        private IValidator<UpdateClientRequest> _updateClientValidator;

        public ClientService(IViacepService viacepService, IClientRepository repository, IMapper mapper, IValidator<CreateClientRequest> createClientValidator, IValidator<UpdateClientRequest> updateClientValidator)
        {
            _viacepService = viacepService;
            _repository = repository;
            _mapper = mapper;
            _createClientValidator = createClientValidator;
            _updateClientValidator = updateClientValidator;
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

            var validationResult = _createClientValidator.Validate(request);
            response.AddErrors(validationResult.Errors);
            
            if (!await ValidateCEP(request.Cep))
            {
                response.Errors.Add("CEP not valid.");
            }

            if (response.Errors.Count > 0)
            {
                return response;
            }

            var client = _mapper.Map<Client>(request);
            response.Value = await _repository.Create(client);

            return response;
        }

        public async Task<Response<GetClientResponse>> Update(UpdateClientRequest request)
        {
            var response = new Response<GetClientResponse>();

            var validationResult = _updateClientValidator.Validate(request);
            response.AddErrors(validationResult.Errors);

            if (!await ValidateCEP(request.Cep))
            {
                response.Errors.Add("CEP not valid.");
            }

            if (response.Errors.Count > 0)
            {
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

        public async Task<Response<bool>> Delete(long id)
        {
            var response = new Response<bool>();
            response.Value = await _repository.Delete(id);

            return response;
        }

        private async Task<bool> ValidateCEP(string cep)
        {
            var result = await _viacepService.Validate(cep);
            return result;
        }
    }
}
