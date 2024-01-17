using ApiRegister.DTOs;
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
        public async Task<ActionResult<Response<GetClientResponse>>> Get([FromQuery] long Id)
        {
            var response = await _clientService.Get(Id);

            return response;
        }

        [HttpGet("list")]
        public async Task<ActionResult<Response<List<GetClientResponse>>>> GetList()
        {
            var response = await _clientService.GetList();

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<Response<string>>> Create(CreateClientRequest createClientRequest)
        {
            var response = await _clientService.Create(createClientRequest);

            return response;
        }

        [HttpPut]
        public async Task<ActionResult<Response<GetClientResponse>>> Update(UpdateClientRequest updateClientRequest)
        {
            var response = await _clientService.Update(updateClientRequest);

            return response;
        }

        [HttpDelete]
        public async Task<bool> Delete(long id)
        {
            var response = await _clientService.Delete(id);
            return response;
        }
    }
}
