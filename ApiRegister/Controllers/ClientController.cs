using ApiRegister.DTOs.Clients;
using ApiRegister.Services.Clients;
using Microsoft.AspNetCore.Mvc;

namespace ApiRegister.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<GetClientResponse> Get(string Id)
        {
            var response = await _clientService.Get(Id);
            return response;
        }

        [HttpGet("list")]
        public async Task<List<GetClientResponse>> GetList()
        {
            var response = await _clientService.GetList();
            return response;
        }

        [HttpPost]
        public async Task<string> Create(CreateClientRequest createClientRequest)
        {
            var response = await _clientService.Create(createClientRequest);
            return response;
        }

        [HttpPut]
        public async Task<GetClientResponse> Update(UpdateClientRequest updateClientRequest)
        {
            var response = await _clientService.Update(updateClientRequest);
            return response;
        }

        [HttpDelete]
        public async Task<bool> Delete(string id)
        {
            var response = await _clientService.Delete(id);
            return response;
        }
    }
}
