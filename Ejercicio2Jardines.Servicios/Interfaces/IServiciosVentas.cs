using Ejercicio2Jardines.Entidades.Dtos.Venta;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Interfaces
{
    public interface IServiciosVentas
    {
        bool Existe(Venta venta);
        void Guardar(Venta venta);
        int GetCantidad(DateTime? fechaFiltro, string textoFiltro);
        List<VentaDto> GetVentas(Cliente cienteFiltro);
        List<VentaDto> GetVentasPorPagina(int registrosPorPagina, int paginaActual, DateTime? fechaFiltro, string textoFiltro);
    }
}
