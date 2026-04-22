namespace ClinicaDocMais.Models
{
    public class AgendamentoModel
    {
        public string? id { get; set; } 
        public string? nomePaciente {  get; set; }
        public string? telefonePaciente { get; set; }
        public string? cpfPaciente { get; set; }

        public string? nomeMedico { get; set; }
        public string? crmMedico { get; set; }
        public string? especialidadeMedico { get; set; }

        public DateTime dataHoraAgendamento { get; set; }
        public bool pacientePresente { get; set; }
        public bool medicoPresente { get; set; }
    }
}
