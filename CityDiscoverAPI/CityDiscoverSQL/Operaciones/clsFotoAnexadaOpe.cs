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
    public class clsFotoAnexadaOpe : IBase<clsFotoAnexadaModelo, int>
    {

        private CityDiscoverContexto db;

        public clsFotoAnexadaOpe(CityDiscoverContexto _db)
        {
            db = _db;
        }

        public void Actualizar(clsFotoAnexadaModelo entidad)
        {
            var Selecc = db.FotoAnexadaEntidad.Where(olinea => olinea.IdFotoAnexada == entidad.IdFotoAnexada).FirstOrDefault();

            if (Selecc != null)
            {
                Selecc.bnImagen = entidad.bnImagen;

                db.Entry(Selecc).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public void Eliminar(int entidadID)
        {
            var Selecc = db.FotoAnexadaEntidad.Where(olinea => olinea.IdFotoAnexada == entidadID).FirstOrDefault();

            if (Selecc != null)
            {
                db.FotoAnexadaEntidad.Remove(Selecc);
            }
        }

        public clsFotoAnexadaModelo Insertar(clsFotoAnexadaModelo entidad)
        {
            db.FotoAnexadaEntidad.Add(entidad.Map());
            return entidad;
        }

        public clsFotoAnexadaModelo ObtenerPorID(int entidadID)
        {
            var Selecc = db.FotoAnexadaEntidad.Where(olinea => olinea.IdFotoAnexada == entidadID).FirstOrDefault();
            if (Selecc == null)
                return new clsFotoAnexadaModelo();
            else
                return Selecc.Map();
        }

        public List<clsFotoAnexadaModelo> ObtenerTodo()
        {
            return db.FotoAnexadaEntidad.ToList().Map();
        }

        public void SalvarTodo()
        {
            db.SaveChanges();
        }
    }
}
