using Examen.Context;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscoController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public DiscoController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("AgregarDisco")]
        public async Task<IActionResult> Post([FromBody] Disco disco)
        {
            _aplicacionContext.Disco.Add(disco);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Agregado correctamente el disco");
        }
        [HttpGet]
        [Route("MostrarDisco")]
        public async Task<IActionResult> Get()
        {
            List<Disco> listaDiscos = _aplicacionContext.Disco.OrderByDescending(e => e.idDisco).ToList();
            return StatusCode(StatusCodes.Status200OK, listaDiscos);
        }
        [HttpPut]
        [Route("EditarDisco/")]
        public async Task<IActionResult> Put([FromBody] Disco disco)
        {
            _aplicacionContext.Disco.Update(disco);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Editado correctamente el disco");
        }
        [HttpDelete]
        [Route("EliminarDisco/")]
        public async Task<IActionResult> Delete(int? id)
        {
           Disco disco = _aplicacionContext.Disco.Find(id);
            _aplicacionContext.Disco.Remove(disco);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Eliminado correctamente el disco");
        }
    }
}
