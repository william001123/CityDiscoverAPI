using CityDiscoverAPI.Filtros;
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
    //[EnableCors("ReglasCors")]
    //[Authorize]

    //Si se necesita configurar un parametro por defecto en las peticiones, se debe activar [AcepteLenguajeHeader],
    //es una clase de configuracion para los parametros en Swagger
    //[AcepteLenguajeHeader]
    public class TipoLugarController : ControllerBase
    {
        private readonly IServicioBase<clsTipoLugarModelo, int> db;

        public TipoLugarController(IServicioBase<clsTipoLugarModelo, int> _db)
        {
            db = _db;
        }

        [HttpGet]
        public ActionResult<List<clsTipoLugarDTO>> ObtenerTodo()
        {
            //return Ok(db.ObtenerTodo().Map());
            return Ok(new clsTipoLugarDTO { IdTipoLugar = 1, strNombre = "Prueba"});
        }

        [HttpGet("{id}")]
        public ActionResult<List<clsTipoLugarDTO>> ObtenetPorID(int id)
        {
            return Ok(db.ObtenerPorID(id).Map());
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsTipoLugarDTO entidad)
        {
            db.Insertar(entidad.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());

        }

        //[HttpPut("{id}")]
        [HttpPut]
        public ActionResult Actualizar([FromBody] clsTipoLugarDTO entidad)
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
