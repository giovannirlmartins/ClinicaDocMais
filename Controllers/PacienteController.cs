using ClinicaDocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PacienteController : Controller
    {
        public static List<PacienteModel> listaPaciente = new List<PacienteModel>();

        //cadastrarPaciente
        [HttpPost("cadastrarpaciente")]
        public async Task<IActionResult> CadastrarPaciente([FromBody] PacienteModel pacienteCadastrado)
        {
            try
            {
                listaPaciente.Add(pacienteCadastrado);
                return Created();
            }
            catch (Exception ex)
            { 
                return BadRequest("Erro Inesperado: "+ex.Message);
            }
        }
       
        [HttpGet("listarpacientes")]
        public List<PacienteModel> listarPaciente()
        {
            return listaPaciente;
        }

        [HttpGet("buscaPaciente/{id}")]
        public PacienteModel? buscarPaciente(string id)
        {
            foreach (var paciente in listaPaciente)
            {
                if(paciente.cpf == id)
                {
                    return paciente;
                }
            }

            return null;
        }

        [HttpPut("editarPaciente/{id}")]
        public string editarPaciente([FromBody] PacienteModel pacienteEditado, string id) 
        {
            foreach (var paciente in listaPaciente)
            {
                if (paciente.cpf==id)
                {
                    paciente.cpf = pacienteEditado.cpf;
                    paciente.nome = pacienteEditado.nome;
                    paciente.telefone = pacienteEditado.telefone;
                    paciente.email = pacienteEditado.email;
                    paciente.dataNascimento = pacienteEditado.dataNascimento;
                    paciente.endereco = pacienteEditado.endereco;
                    return $"Paciente {paciente.nome}, cpf anterior: {id} editado com sucesso";
                }
            }

            return "Paciente não encontrado.";
        }

        [HttpDelete("deletarPaciente/{id}")]
        public string deletarPaciente(string id)
        {
            foreach (var paciente in listaPaciente)
            {
                if (paciente.cpf==id)
                {
                    listaPaciente.Remove(paciente);
                    return $"Paciente com cpf: {id} deletado com sucesso";
                }
            }
            return "Paciente não encontrado";
        }
    }
}
