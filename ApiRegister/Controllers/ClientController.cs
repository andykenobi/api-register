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

        [HttpGet("{id}")]
        public async Task<ActionResult<Response<GetClientResponse>>> Get(long id)
        {
            var response = await _clientService.Get(id);

            return response;
        }

        [HttpGet]
        public async Task<ActionResult<Response<List<GetClientResponse>>>> GetList()
        {
            var response = await _clientService.GetList();

            return response;
        }

        [HttpPost]
        public async Task<ActionResult<Response<string>>> Create(CreateClientRequest createClientRequest)
        {
            var response = await _clientService.Create(createClientRequest);

            if (response.Errors.Count > 0)
            {
                return BadRequest(response);
            }

            return response;
        }

        [HttpPut]
        public async Task<ActionResult<Response<GetClientResponse>>> Update(UpdateClientRequest updateClientRequest)
        {
            var response = await _clientService.Update(updateClientRequest);

            return response;
        }

        [HttpDelete("{id}")]
        public async Task<Response<bool>> Delete(long id)
        {
            var response = await _clientService.Delete(id);
            return response;
        }
    }
}
