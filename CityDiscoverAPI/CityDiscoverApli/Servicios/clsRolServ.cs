using CityDiscoverApli.Interfaces;
using CityDiscoverApli.Maestras;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using static CityDiscoverApli.Maestras.MensajesBase;

namespace CityDiscoverApli.Servicios
{
    public class clsRolServ
        : IServicioBase<clsRolModelo, int>
    {
        private readonly IBase<clsRolModelo, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsRolServ(IBase<clsRolModelo, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsRolModelo entidad)
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

        public clsRolModelo Insertar(clsRolModelo entidad)
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

        public clsRolModelo ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsRolModelo> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
