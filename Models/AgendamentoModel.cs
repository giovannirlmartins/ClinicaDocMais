namespace ClinicaDocMais.Models
{
    public class AgendamentoModel
    {
        public string? id { get; set; } 

        public string? cpfPaciente { get; set; }
        public PacienteModel? paciente { get; set; }

        public string? crmMedico { get; set; }
        public MedicoModel? medico { get; set; }    

        public DateTime dataHoraAgendamento { get; set; }
        public bool pacientePresente { get; set; }
        public bool medicoPresente { get; set; }
    }
}
