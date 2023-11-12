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
    public class clsRol_AutenticacionOpe : IIntermedia<clsRol_AutenticacionModelo>
    {

        private CityDiscoverContexto db;

        public clsRol_AutenticacionOpe(CityDiscoverContexto _db)
        {
            db = _db;
        }    

        public void Eliminar(clsRol_AutenticacionModelo entidadID)
        {
            var Selecc = db.Rol_AutenticacionEntidad.Where(olinea => olinea.IdRol == entidadID.IdRol && olinea.Usuario == entidadID.Usuario).FirstOrDefault();

            if (Selecc != null)
            {
                db.Rol_AutenticacionEntidad.Remove(Selecc);
            }
        }

        public clsRol_AutenticacionModelo Insertar(clsRol_AutenticacionModelo entidad)
        {
            db.Rol_AutenticacionEntidad.Add(entidad.Map());
            return entidad;
        }

        public clsRol_AutenticacionModelo ObtenerPorID(clsRol_AutenticacionModelo entidadID)
        {
            var Selecc = db.Rol_AutenticacionEntidad.Where(olinea => olinea.IdRol == entidadID.IdRol && olinea.Usuario == entidadID.Usuario).FirstOrDefault();
            if (Selecc == null)
                return new clsRol_AutenticacionModelo();
            else
                return Selecc.Map();
        }

        public List<clsRol_AutenticacionModelo> ObtenerTodo()
        {
            return db.Rol_AutenticacionEntidad.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
