using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverDom.Interfaces.Base
{
    public interface IBase<TEntidad, TEntidadID>
        : IInsertar<TEntidad>, IActualizar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>, ISalvarTodo
    {
    }
}
