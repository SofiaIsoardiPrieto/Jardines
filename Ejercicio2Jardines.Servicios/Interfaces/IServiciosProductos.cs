using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Interfaces
{
    public interface IServiciosProductos
    {
        bool Existe(Producto producto);
        void Guardar(Producto producto);
    }
}
