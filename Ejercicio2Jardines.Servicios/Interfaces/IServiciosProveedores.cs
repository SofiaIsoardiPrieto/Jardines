using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Proveedor;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Interfaces
{
    public interface IServiciosProveedores
    {
        bool Existe(Proveedor proveedor);
        int GetCantidad(string textoFiltro);
        
        List<ProveedorDto> GetProveedoresPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro);
        void Guardar(Proveedor proveedor);
        List<ProveedorComboDto> GetProveedoresComboDto();


    }
}
