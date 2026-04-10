using ClinicaDocMais.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmergenciaController : Controller
    {
        public static List<PacienteModel> listaPaciente = new List<PacienteModel>();

        [HttpGet("retornoCasa")]
        public string casa()
        {
            return "casa";
        }

        [HttpGet("nomePaciente")]
        public string paciente()
        {
            string nome = "Giovanni";
            return "Paciente: " + nome;
        }

        [HttpGet("listaPacientes")]
        public List<string> listaNome()
        {
            List<string> listaPacientes = new List<string>();
            listaPacientes = ["Giovanni", "Carlos", "Pedro"];
            return listaPacientes;
        }

        [HttpGet("pacientes")]
        public List<PacienteModel> listarPaciente()
        {
            PacienteModel novoPaciente = new PacienteModel("1019210", "Giovanni", "10/04/1999", "Vermelha");
            listaPaciente.Add(novoPaciente);
            novoPaciente = new PacienteModel("1020220", "Eduarda", "15/03/1990", "Verde");
            listaPaciente.Add(novoPaciente);
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
                    paciente.prioridade = pacienteEditado.prioridade;
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
