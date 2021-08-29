using Api.Calculo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Calculo.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CalcularController : ControllerBase
    {
        private readonly ICalculoService _calculoService;

        public CalcularController(ICalculoService calculoService)
        {
            _calculoService = calculoService;
        }

        [HttpGet("{numero}")]
        public async Task<ActionResult> Get(int numero) => Ok(_calculoService.ObterNumerosDivisoresEPrimos(numero));
    }
}
