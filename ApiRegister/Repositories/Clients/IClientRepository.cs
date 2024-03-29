﻿using ApiRegister.Models;

namespace ApiRegister.Repositories.Clients
{
    public interface IClientRepository
    {
        Task<List<Client>> GetList();
        Task<Client> Get(long id);
        Task<string> Create(Client client);
        Task<Client> Update(Client client);
        Task<bool> Delete(long id);

    }
}
