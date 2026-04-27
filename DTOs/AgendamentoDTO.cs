
using ClinicaDocMais.Models;

namespace ClinicaDocMais.DTOs
{
    public class AgendamentoDTO
    {
        public string? id { get; set; }
        public string? cpfPaciente { get; set; }
        public string? crmMedico { get; set; }
        public DateTime dataHoraAgendada { get; set; }
    }
}
