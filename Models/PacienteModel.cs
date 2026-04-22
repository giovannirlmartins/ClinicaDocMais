using System.ComponentModel.DataAnnotations;

namespace ClinicaDocMais.Models
{
    public class PacienteModel
    {
        [Key] public string? cpf { get; set; }
        public string? nome { get; set; }
        public string? telefone { get; set; }
        public DateOnly? dataNascimento { get; set; }
        public string? endereco { get; set; }
        public string? email { get; set; }
    }
}
