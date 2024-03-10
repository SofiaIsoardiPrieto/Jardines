using Ejercicio2Jardines.Entidades.Dtos.Venta;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Datos.Interfaces
{
    public interface IRepositorioVentas
    {
        bool Existe(Venta venta);
        int GetCantidad(DateTime? fechaFiltro, string textoFiltro);
        List<VentaDto> GetVentas(Cliente clienteFiltro);
        List<VentaDto> GetVentasPorPagina(int registrosPorPagina, int paginaActual, DateTime? fechaFiltro, string textoFiltro);
        void Guardar(Venta venta);
    }
}
