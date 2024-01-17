using ApiRegister.Repositories.Clients;

namespace ApiRegister.Services.Clients
{
    public class GetClientListService
    {
        private GetClientListRepository _repository;

        public GetClientListService(GetClientListRepository repository)
        {
            _repository = repository;
        }
    }
}
