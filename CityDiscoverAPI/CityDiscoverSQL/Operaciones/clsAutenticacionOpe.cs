using CityDiscoverSQL.Contextos;
using CityDiscoverSQL.Entidades;
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
    public class clsAutenticacionOpe : IAutenticacion<clsAutenticacionModelo, string>
    {

        private CityDiscoverContexto db;

        public clsAutenticacionOpe(CityDiscoverContexto _db)
        {
            db = _db;
        }

        public clsAutenticacionModelo Insertar(clsAutenticacionModelo entidad)
        {
            db.AutenticacionEntidad.Add(entidad.Map());
            return entidad;
        }

        public clsAutenticacionModelo ObtenerAutenticacion(string Usuario, string Contrasena)
        {

            var Selecc = db.AutenticacionEntidad.Where(olinea => olinea.Usuario == Usuario && olinea.Contrasena == Contrasena).FirstOrDefault();

            if (Selecc == null)
                return new clsAutenticacionModelo();
            else
                return Selecc.Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
