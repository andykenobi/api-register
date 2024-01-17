using ApiRegister.Repositories.Clients;

namespace ApiRegister.Services.Clients
{
    public class DeleteClientService
    {
        private DeleteClientRepository _repository;

        public DeleteClientService(DeleteClientRepository repository)
        {
            _repository = repository;
        }

        public async Task Delete()
        {

        }
    }
}
