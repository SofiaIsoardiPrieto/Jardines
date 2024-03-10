using Ejercicio2Jardines.Entidades.Dtos.Compra;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Interfaces
{
    public interface IServiciosCompras
    {
        bool Existe(Compra compra);
        void Guardar(Compra compra);
        int GetCantidad(DateTime? fechaFiltro, string textoFiltro);
        List<CompraDto> GetCompras(Proveedor proveedorFiltro);
        List<CompraDto> GetComprasPorPagina(int registrosPorPagina, int paginaActual, DateTime? fechaFiltro, string textoFiltro);
    }
}
