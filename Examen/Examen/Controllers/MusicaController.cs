using Examen.Context;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicaController : Controller
    {
        public readonly AplicacionContext _aplicacionContext;
        public MusicaController(AplicacionContext context)
        {
            _aplicacionContext = context;
        }
        [HttpPost]
        [Route("AgregarMusica")]
        public async Task<IActionResult> Post([FromBody] Musica musica)
        {
            _aplicacionContext.Musica.Add(musica);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Agregado");
        }
        [HttpGet]
        [Route("MostrarMusica")]
        public async Task<IActionResult> Get()
        {
            List<Musica> listaMusica = _aplicacionContext.Musica.OrderByDescending(e => e.idMusica).ToList();
            return StatusCode(StatusCodes.Status200OK, listaMusica);
        }
        [HttpPut]
        [Route("EditarMusica/")]
        public async Task<IActionResult> Put([FromBody] Musica musica)
        {
            _aplicacionContext.Musica.Update(musica);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Editado correctamente");
        }
        [HttpDelete]
        [Route("EliminarMusica/")]
        public async Task<IActionResult> Delete(int? id)
        {
            Musica auto = _aplicacionContext.Musica.Find(id);
            _aplicacionContext.Musica.Remove(auto);
            await _aplicacionContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status200OK, "Eliminado correctamente");

        }
    }
}
