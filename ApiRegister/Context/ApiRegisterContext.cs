using ApiRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiRegister.Context
{
    public class ApiRegisterContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("test");
        }
    }
}
