﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverDom.Interfaces
{
    public interface IEliminar<TEntidadID>
    {
        void Eliminar(TEntidadID entidadID);
    }
}
