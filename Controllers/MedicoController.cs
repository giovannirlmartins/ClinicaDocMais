using ClinicaDocMais.Models;
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

        //buscar médico

        //excluir médico
    }
}
