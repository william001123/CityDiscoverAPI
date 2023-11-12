using CityDiscoverApli.Interfaces;
using CityDiscoverApli.Maestras;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using static CityDiscoverApli.Maestras.MensajesBase;

namespace CityDiscoverApli.Servicios
{
    public class clsAutenticacionServ
        : IServicioAutenticacion<clsAutenticacionModelo, string>
    {
        private readonly IAutenticacion<clsAutenticacionModelo, string> repo;
        private Excepcion excepcion = new Excepcion();
        private string secretKey = "";

        //El objeto que recibiremos es una clase concreta que implemente la interfaz base del dominio
        //y ejecute las operaciones en alguna tecnologia sin necesidad que el servicio la reconozca

        public clsAutenticacionServ(IAutenticacion<clsAutenticacionModelo, string> _repo, IConfiguration config)
        {
            repo = _repo;
            secretKey = config.GetSection("settings").GetSection("secretKey").ToString();
        }

        public clsAutenticacionModelo Insertar(clsAutenticacionModelo entidad)
        {
            try
            {
                entidad.Contrasena = Encrypt.Encriptar(entidad.Contrasena);
                var result = repo.Insertar(entidad);
                repo.SalvarTodo();
                return result;
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public clsAutenticacionModelo ObtenerAutenticacion(string Usuario, string Contrasena)
        {
            Contrasena = Encrypt.Encriptar(Contrasena);
            return repo.ObtenerAutenticacion(Usuario, Contrasena);
        }

        public string Token(string Usuario)
        {
            var keyBytes = Encoding.ASCII.GetBytes(secretKey);
            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, Usuario));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

            string tokencreado = tokenHandler.WriteToken(tokenConfig);

            return tokencreado;
        }

    }
}
