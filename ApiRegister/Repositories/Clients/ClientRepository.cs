using ApiRegister.Models;

namespace ApiRegister.Repositories.Clients
{
    public class ClientRepository : IClientRepository
    {

        public async Task<string> Create(Client client)
        {
            return "";
        }

        public async Task<bool> Delete(string id)
        {
            return false;
        }

        public async Task<List<Client>> GetList()
        {
            return null;
        }

        public async Task<Client> Get(string id)
        {
            return null;
        }

        public async Task<Client> Update(Client client)
        {
            return null;
        }
    }
}
