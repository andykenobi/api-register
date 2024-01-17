using System.ComponentModel.DataAnnotations;

namespace ApiRegister.DTOs.Clients
{
    public class CreateClientRequest
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Birthday { get; set; } = string.Empty;
        [Required]
        public string Cep { get; set; } = string.Empty;
    }
}
