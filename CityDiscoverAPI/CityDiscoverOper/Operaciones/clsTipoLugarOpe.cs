using CityDiscoverOper.Contextos;
using CityDiscoverOper.Mappers;
using CityDiscoverDom.Interfaces.Base;
using CityDiscoverDom.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverOper.Operaciones
{
    public class clsTipoLugarOpe : IBase<clsTipoLugarModelo, int>
    {

        private CityDiscoverContexto db;

        public clsTipoLugarOpe(CityDiscoverContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsTipoLugarModelo entidad)
        {
            var Selecc = db.TipoLugarEntidad.Where(olinea => olinea.IdTipoLugar == entidad.IdTipoLugar).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strNombre = entidad.strNombre;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.TipoLugarEntidad.Where(olinea => olinea.IdTipoLugar == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.TipoLugarEntidad.Remove(Selecc);
            }
        }

        public clsTipoLugarModelo Insertar(clsTipoLugarModelo entidad)
        {
            db.TipoLugarEntidad.Add(entidad.Map());
            return entidad;
        }

        public clsTipoLugarModelo ObtenerPorID(int entidadID)
        {
            var Selecc = db.TipoLugarEntidad.Where(olinea => olinea.IdTipoLugar == entidadID).FirstOrDefault();
            if (Selecc == null)
                return new clsTipoLugarModelo();
            else
                return Selecc.Map();
        }

        public List<clsTipoLugarModelo> ObtenerTodo()
        {
            return db.TipoLugarEntidad.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
