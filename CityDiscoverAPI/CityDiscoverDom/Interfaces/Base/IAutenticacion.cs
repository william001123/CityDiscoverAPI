using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverDom.Interfaces.Base
{
    public interface IAutenticacion<TEntidad, TEntidadID>
        : IInsertar<TEntidad>, ISalvarTodo
    {
        TEntidad ObtenerAutenticacion(TEntidadID Usuario, TEntidadID Contrasena);
    }
}
