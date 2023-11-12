using CityDiscoverDom.Interfaces;

namespace CityDiscoverApli.Interfaces
{
    public interface IServicioBase<TEntidad, TEntidadID>
        : IInsertar<TEntidad>, IActualizar<TEntidad>, IEliminar<TEntidadID>, IListar<TEntidad, TEntidadID>
    {
    }
}
