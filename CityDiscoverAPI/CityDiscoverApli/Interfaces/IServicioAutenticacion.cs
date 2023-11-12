using CityDiscoverDom.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverApli.Interfaces
{
    public interface IServicioAutenticacion<TEntidad, TEntidadID>
        : IInsertar<TEntidad>
    {
        TEntidad ObtenerAutenticacion(TEntidadID Usuario, TEntidadID Contrasena);
        string Token(TEntidadID Usuario);
    }
}
