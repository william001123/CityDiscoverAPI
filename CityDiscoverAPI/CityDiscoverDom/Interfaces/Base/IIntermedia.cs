using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverDom.Interfaces.Base
{
    public interface IIntermedia<TEntidad>
        : IInsertar<TEntidad>, IEliminar<TEntidad>, IListar<TEntidad, TEntidad>, ISalvarTodo
    {
    }
}
