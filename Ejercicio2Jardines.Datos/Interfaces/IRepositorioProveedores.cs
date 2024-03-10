using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Proveedor;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Datos.Interfaces
{
    public interface IRepositorioProveedores
    {
        void Agregar(Proveedor proveedor);
        void Borrar(int proveedorId);
        void Editar(Proveedor proveedor);
        bool Existe(Proveedor proveedor);
        int GetCantidad(string textoFiltro);
        List<ProveedorDto> GetProveedores(CiudadDto ciudadFiltro, Pais paisFiltro);
        List<ProveedorComboDto> GetProveedoresComboDto();
        List<ProveedorDto> GetProveedoresPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro);
        
       
    }
}
