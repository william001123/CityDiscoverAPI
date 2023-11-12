using CityDiscoverSQL.Contextos;
using CityDiscoverSQL.Mappers;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverSQL.Operaciones
{
    public class clsUbicacionOpe : IBase<clsUbicacionModelo, int>
    {

        private CityDiscoverContexto db;

        public clsUbicacionOpe(CityDiscoverContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsUbicacionModelo entidad)
        {
            var Selecc = db.UbicacionEntidad.Where(olinea => olinea.IdUbicacion == entidad.IdUbicacion).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strNombre = entidad.strNombre;
                Selecc.strDescripcion = entidad.strDescripcion;
                Selecc.numLatitud = entidad.numLatitud;
                Selecc.numLongitud = entidad.numLongitud;
                Selecc.IdTipoLugar = entidad.IdTipoLugar;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.UbicacionEntidad.Where(olinea => olinea.IdUbicacion == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.UbicacionEntidad.Remove(Selecc);
            }
        }

        public clsUbicacionModelo Insertar(clsUbicacionModelo entidad)
        {
            db.UbicacionEntidad.Add(entidad.Map());
            return entidad;
        }

        public clsUbicacionModelo ObtenerPorID(int entidadID)
        {
            var Selecc = db.UbicacionEntidad.Where(olinea => olinea.IdUbicacion == entidadID).FirstOrDefault();
            if (Selecc == null)
                return new clsUbicacionModelo();
            else
                return Selecc.Map();
        }

        public List<clsUbicacionModelo> ObtenerTodo()
        {
            return db.UbicacionEntidad.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
