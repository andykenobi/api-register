using ApiRegister.Repositories.Clients;

namespace ApiRegister.Services.Clients
{
    public class GetClientService
    {
        private GetClientRepository _repository;

        public GetClientService(GetClientRepository repository)
        {
            _repository = repository;
        }

        public async Task Get()
        {

        }
    }
}
