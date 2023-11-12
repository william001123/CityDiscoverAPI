using CityDiscoverApli.Interfaces;
using CityDiscoverDom.Modelos;
using CityDiscoverDTO.DTOs;
using CityDiscoverDTO.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using static CityDiscoverAPI.Maestras.MensajesBase;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityDiscoverAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ReglasCors")]
    [Authorize]
    public class RolController : ControllerBase
    {
        private readonly IServicioBase<clsRolModelo, int> db;

        public RolController(IServicioBase<clsRolModelo, int> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsRolDTO>> ObtenerTodo()
        {
            return Ok(db.ObtenerTodo().Map());
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsRolDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsRolDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        //[HttpPut("{id}")]
        [HttpPut]
        public ActionResult Actualizar([FromBody] clsRolDTO entidad)
        {
            db.Actualizar(entidad.Map());
            return Ok(Satisfactorio.Actualizado.GetEnumDescription());
        }

        [HttpDelete("{id}")]
        public void Eliminar(int id)
        {
            db.Eliminar(id);
        }
    }
}
