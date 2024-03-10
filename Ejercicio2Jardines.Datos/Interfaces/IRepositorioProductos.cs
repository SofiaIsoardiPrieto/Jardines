using Ejercicio2Jardines.Entidades.Dtos.Producto;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Datos.Interfaces
{
    public interface IRepositorioProductos
    {
        void Agregar(Producto producto);
        void Borrar(int productoId);
        void Editar(Producto producto);
        bool Existe(Producto producto);
        int GetCantidad(string textoFiltro);
        Producto GetProductosPorId(int productoId);
        List<ProductoDto> GetProductosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro);
    }
}
