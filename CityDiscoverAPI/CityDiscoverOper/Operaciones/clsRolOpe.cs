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
    public class clsRolOpe : IBase<clsRolModelo, int>
    {

        private CityDiscoverContexto db;

        public clsRolOpe(CityDiscoverContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsRolModelo entidad)
        {
            var Selecc = db.RolEntidad.Where(olinea => olinea.IdRol == entidad.IdRol).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.strNombre = entidad.strNombre;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.RolEntidad.Where(olinea => olinea.IdRol == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.RolEntidad.Remove(Selecc);
            }
        }

        public clsRolModelo Insertar(clsRolModelo entidad)
        {
            db.RolEntidad.Add(entidad.Map());
            return entidad;
        }

        public clsRolModelo ObtenerPorID(int entidadID)
        {
            var Selecc = db.RolEntidad.Where(olinea => olinea.IdRol == entidadID).FirstOrDefault();
            if (Selecc == null)
                return new clsRolModelo();
            else
                return Selecc.Map();
        }

        public List<clsRolModelo> ObtenerTodo()
        {
            return db.RolEntidad.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
