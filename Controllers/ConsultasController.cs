using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaDocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {

        //Método Http que retorne os pacientes atendidos hoje (nome)
        [HttpGet("atendidosHoje")]
        public List<string> pacientesAtendidosHoje()
        {
            //a lógica para retornar os nomes dos pacientes (pelo menos 3)
            List<string> pacientesAtendidosHoje = new List<string>();
            pacientesAtendidosHoje = ["Giovanni", "Ricardo", "Sérgio"];
            return pacientesAtendidosHoje;
        }


    }
}
