using CityDiscoverApli.Interfaces;
using CityDiscoverDom.Modelos;
using CityDiscoverDTO.DTOs;
using CityDiscoverDTO.Mappers;
using Microsoft.AspNetCore.Mvc;
using static CityDiscoverAPI.Maestras.MensajesBase;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityDiscoverAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //Cuando el end point retorna el token y se quiera probar en Swagger se debe poner Bearer antes del token en la Autorizacion, ejm
    //Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiJ3aWxsaWFtIiwibmJmIjoxNjk1Njg4MjU5LCJleHAiOjE2OTU2ODg1NTksImlhdCI6MTY5NTY4ODI1OX0.a1B2lo6oCUsrIAonyF557SDJdAilPBveRKXp1Y40SMk
    //Si se va a probar en postman, el token se pone en el tipo de autorizacion Bearer Token, y ahí se pone el token

    public class AutenticacionController : ControllerBase
    {
        private readonly IServicioAutenticacion<clsAutenticacionModelo, string> db;

        public AutenticacionController(IServicioAutenticacion<clsAutenticacionModelo, string> _db)
        {
            db = _db;
        }

        [HttpPost]
        public ActionResult Insertar([FromBody] clsAutenticacionDTO autenticacion)
        {
            db.Insertar(autenticacion.Map());
            return Ok(Satisfactorio.Insertado.GetEnumDescription());
        }

        [HttpPost]
        [Route("Validar")]
        public ActionResult ObtenerAutenticacion([FromBody] clsAutenticacionDTO autenticacion)
        {
            var selec = db.ObtenerAutenticacion(autenticacion.Usuario, autenticacion.Contrasena).Map();

            if (selec != null)
            {
                var tokencreado = db.Token(autenticacion.Usuario);
                return StatusCode(StatusCodes.Status200OK, new { token = tokencreado });
            }
            else
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { token = "" });
            }
        }
    }
}
