using System.ComponentModel.DataAnnotations;

namespace ApiRegister.DTOs.Clients
{
    public class UpdateClientRequest
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
    }
}
