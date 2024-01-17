using ApiRegister.DTOs;
using ApiRegister.Services.Viaceps;
using Microsoft.AspNetCore.Mvc;

namespace ApiRegister.Controllers
{
    [Route("api/cep")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private IViacepService _viacepService { get; set; }

        public CepController(IViacepService viacepService)
        {
            _viacepService = viacepService;
        }

        [HttpGet("validate")]
        public async Task<Response<bool>> Get(string cep)
        {
            var response = await _viacepService.Validate(cep);
            return response;
        }
    }
}
