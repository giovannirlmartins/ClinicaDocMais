namespace ClinicaDocMais.Models
{
    public class ChamadaModel
    {
        public string? nomePaciente { get; set; }
        public string? consultorio { get; set; }
        public static List<string> chamadaPaciente = new List<string>();
    }
}
