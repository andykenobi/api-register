namespace ApiRegister.DTOs.Clients
{
    public class UpdateClientRequest
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Birthday { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
    }
}
