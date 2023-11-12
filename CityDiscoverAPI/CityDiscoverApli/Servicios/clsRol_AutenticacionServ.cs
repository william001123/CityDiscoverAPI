using CityDiscoverApli.Interfaces;
using CityDiscoverApli.Maestras;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using static CityDiscoverApli.Maestras.MensajesBase;

namespace CityDiscoverApli.Servicios
{
    public class clsRol_AutenticacionServ
        : IServicioIntermedia<clsRol_AutenticacionModelo>
    {
        private readonly IIntermedia<clsRol_AutenticacionModelo> repo;
        private Excepcion excepcion = new Excepcion();

        public clsRol_AutenticacionServ(IIntermedia<clsRol_AutenticacionModelo> _repo) 
        {
            repo = _repo;
        }

        public void Eliminar(clsRol_AutenticacionModelo entidadID)
        {
            repo.Eliminar(entidadID);
            repo.SalvarTodo();
        }

        public clsRol_AutenticacionModelo Insertar(clsRol_AutenticacionModelo entidad)
        {
            try
            {
                var result = repo.Insertar(entidad);
                repo.SalvarTodo();
                return result;
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public clsRol_AutenticacionModelo ObtenerPorID(clsRol_AutenticacionModelo entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsRol_AutenticacionModelo> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
