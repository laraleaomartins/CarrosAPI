using CarrosAPI.Models;
using CarrosAPI.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace CarrosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private ICarroServico Servico;
        public CarroController(ICarroServico servico)
        {
            Servico = servico;
        }

        [HttpGet]
        public async Task<IActionResult> BuscarCarros()
        {
            return Ok(await Servico.BuscarCarros());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarCarros(int? id)
        {
            return Ok(await Servico.BuscarCarros(id));
        }

        [HttpPost]
        public async Task<IActionResult> CriarCarro([FromBody]Carro carro)
        {
            return Ok(await Servico.CriarCarro(carro));
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarCarro([FromBody] Carro carro, int id)
        {
            await Servico.AtualizarCarro(carro);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarCarro(int id)
        {
            await Servico.DeletarCarro(id);
            return NoContent();
        }

    }
}
