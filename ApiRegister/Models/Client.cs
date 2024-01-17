using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ApiRegister.Models
{
    public class Client
    {
        [Key]
        public long Id { get; set; }
        [NotNull]
        public string Name { get; set; } = string.Empty;
        [NotNull]
        public string Email { get; set; } = string.Empty;
        [NotNull]
        public string Birthday { get; set; } = string.Empty;
        [NotNull]
        public string Cep { get; set; } = string.Empty;
    }
}
