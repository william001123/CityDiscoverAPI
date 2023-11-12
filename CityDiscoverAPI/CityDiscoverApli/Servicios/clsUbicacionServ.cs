using CityDiscoverApli.Interfaces;
using CityDiscoverApli.Maestras;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using static CityDiscoverApli.Maestras.MensajesBase;

namespace CityDiscoverApli.Servicios
{
    public class clsUbicacionServ
        : IServicioBase<clsUbicacionModelo, int>
    {
        private readonly IBase<clsUbicacionModelo, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsUbicacionServ(IBase<clsUbicacionModelo, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsUbicacionModelo entidad)
        {
            try
            {
                repo.Actualizar(entidad);
                repo.SalvarTodo();
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Actualizar.GetEnumDescription());
            }
        }

        public void Eliminar(int entidadID)
        {
            repo.Eliminar(entidadID);
            repo.SalvarTodo();
        }

        public clsUbicacionModelo Insertar(clsUbicacionModelo entidad)
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

        public clsUbicacionModelo ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsUbicacionModelo> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
