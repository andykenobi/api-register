using ApiRegister.DTOs.Clients;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiRegister.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public async Task<GetClientResponse> Get(string Id)
        {
            return null;
        }

        [HttpGet]
        public async Task<List<GetClientResponse>> GetList()
        {
            return null;
        }

        [HttpPost]
        public async Task<string> Create(CreateClientRequest createClientRequest)
        {
            return "";
        }

        [HttpPut]
        public async Task<GetClientResponse> Update(UpdateClientRequest updateClientRequest)
        {
            return null;
        }

        [HttpDelete]
        public async Task<bool> Delete(string Id)
        {
            return true;
        }
    }
}
