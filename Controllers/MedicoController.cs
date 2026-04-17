using ClinicaDocMais.Models;
using ClinicaDocMais.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        public static List<MedicoModel> listaMedicos = new List<MedicoModel>();

        [HttpPost("cadastroMedico")]
        public string cadastrarMedico([FromBody] MedicoModel medico)
        {
            listaMedicos.Add(medico);
            return $"Dr. {medico.nome} cadastrado com sucesso";
        }

        //listar os médicos
        [HttpGet("listaMedicos")]
        public List<MedicoModel> listarMedicos()
        {
            return listaMedicos;
        }

        //editar médico
        [HttpPut("editarMedico/{crm}")]
        public string editarMedico([FromBody] MedicoModel medicoEditado, string crm) 
        {
            MedicoService medico = new MedicoService();
            medico.editarMedico(medicoEditado, crm);  

            if (medico == null)
            {
                return "Médico não encontrado";
            }
            else
            {
                return $"Médico de CRM Nº {crm} editado com sucesso";
            }
            //ou ele recebe um null caso dê errado
        }

        //buscar médico

        //excluir médico
    }
}
