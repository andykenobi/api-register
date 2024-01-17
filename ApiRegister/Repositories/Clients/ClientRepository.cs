using ApiRegister.Context;
using ApiRegister.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace ApiRegister.Repositories.Clients
{
    public class ClientRepository : IClientRepository
    {
        private Context.ApiRegisterContext _context { get; set; }
        private IMapper _mapper { get; set; }

        public ClientRepository(Context.ApiRegisterContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Client> Get(long id)
        {
            var entity = await _context.Clients.FindAsync(id);

            return entity;
        }

        public async Task<List<Client>> GetList()
        {
            var entities = await _context.Clients
                                        .ToListAsync();

            return entities;
        }

        public async Task<string> Create(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return client.Id.ToString();
        }
        
        public async Task<Client> Update(Client client)
        {
            var entity = await _context.Clients.FindAsync(client.Id);

            if (entity != null)
            {
                entity.Name = client.Name;
                entity.Cep = client.Cep;
                entity.Birthday = client.Birthday;
                entity.Email = client.Email;

                await _context.SaveChangesAsync();
            }

            return entity;

        }

        public async Task<bool> Delete(long id)
        {
            var entity = await _context.Clients.FindAsync(id);

            if (entity == null)
            {
                return false;
            }

            _context.Clients.Remove(entity);
            
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
