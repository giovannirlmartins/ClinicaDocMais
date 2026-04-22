using System.ComponentModel.DataAnnotations;

namespace ClinicaDocMais.Models
{
    public class MedicoModel
    {
        public string? nome { get; set; }
        [Key] public string? crm { get; set; }
        public string? telefone { get; set; }
        public DateOnly? dataNascimento { get; set;}
        public string? especialidade { get; set; }
    }
}
