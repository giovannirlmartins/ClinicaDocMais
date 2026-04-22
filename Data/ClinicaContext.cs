using Microsoft.EntityFrameworkCore;
using ClinicaDocMais.Models;

namespace ClinicaDocMais.Data
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {
            
        }

        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<MedicoModel> Medicos { get; set; }
        public DbSet<AgendamentoModel> Agendamentos { get; set; }
        public DbSet<ChamadaModel> Chamadas { get; set; }

        }
}
