using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Cliente;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Interfaces
{
    public interface IServiciosClientes
    {
        List<ClienteListDto> GetClientes();
        List<ClienteListDto> GetClientes(CiudadDto ciudadFiltro, Pais paisFiltro);
        List<ClienteListDto> GetClientesPorPagina(int cantidad, int paginaActual, string textoFiltro);
        int GetCantidad(string textoFiltro);
        bool Existe(Cliente cliente);
        void Guardar(Cliente cliente);
        void Borrar(int clienteId);
        List<ClienteComboDto> GetClienteComboDto();
    }
}
