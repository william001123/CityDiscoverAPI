using CityDiscoverApli.Interfaces;
using CityDiscoverApli.Maestras;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using static CityDiscoverApli.Maestras.MensajesBase;

namespace CityDiscoverApli.Servicios
{
    public class clsTipoLugarServ
        : IServicioBase<clsTipoLugarModelo, int>
    {
        private readonly IBase<clsTipoLugarModelo, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsTipoLugarServ(IBase<clsTipoLugarModelo, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsTipoLugarModelo entidad)
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

        public clsTipoLugarModelo Insertar(clsTipoLugarModelo entidad)
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

        public clsTipoLugarModelo ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsTipoLugarModelo> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
