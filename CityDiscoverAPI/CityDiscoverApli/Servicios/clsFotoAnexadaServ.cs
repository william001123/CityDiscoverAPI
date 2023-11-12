using CityDiscoverApli.Interfaces;
using CityDiscoverApli.Maestras;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using static CityDiscoverApli.Maestras.MensajesBase;

namespace CityDiscoverApli.Servicios
{
    public class clsFotoAnexadaServ
        : IServicioBase<clsFotoAnexadaModelo, int>
    {
        private readonly IBase<clsFotoAnexadaModelo, int> repo;
        private Excepcion excepcion = new Excepcion();

        public clsFotoAnexadaServ(IBase<clsFotoAnexadaModelo, int> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsFotoAnexadaModelo entidad)
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

        public clsFotoAnexadaModelo Insertar(clsFotoAnexadaModelo entidad)
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

        public clsFotoAnexadaModelo ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public List<clsFotoAnexadaModelo> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
