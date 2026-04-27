using ClinicaDocMais.Data;
using ClinicaDocMais.DTOs;
using ClinicaDocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AgendamentoController : ControllerBase
    {
        private ClinicaContext _context;
        public AgendamentoController(ClinicaContext context)
        {
            _context = context;
        }

        [HttpPost("agendarconsulta")]
        public async Task<IActionResult> AgendarConsulta([FromBody] AgendamentoDTO dadosAgendamento)
        {
            //pegar as informações que vieram no corpo da requisição e jogar na lista
            try
            {
                //CONVERSÃO DE UM DTO PARA UM MODEL
                AgendamentoModel agendamento = new AgendamentoModel();

                agendamento.id = dadosAgendamento.id;
                agendamento.dataHoraAgendamento = dadosAgendamento.dataHoraAgendada;
                agendamento.crmMedico = dadosAgendamento.crmMedico;
                agendamento.cpfPaciente = dadosAgendamento.cpfPaciente;

                await _context.Agendamentos.AddAsync(agendamento);
                _context.SaveChanges();

                return Created();

            }
            catch (Exception ex)
            {
                return BadRequest("Erro Inesperado: " + ex.Message);
            }  
        }

        [HttpGet("buscarAgendamentos")]
        public async Task<IActionResult> BuscarAgendamentos()
        {
            try
            {
                var listaAgendamentos = await _context.Agendamentos.Include(p => p.paciente)
                    .Include(m => m.medico).ToListAsync();
                
                return Ok(listaAgendamentos);

            }catch(Exception ex)
            {
                return BadRequest("Erro. " + ex.Message);
            }
        }
    }
}
