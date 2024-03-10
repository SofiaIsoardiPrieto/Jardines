using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Cliente;
using Ejercicio2Jardines.Entidades.Entidades;
using System.Collections.Generic;

namespace Ejercicio2Jardines.Datos.Interfaces
{
    public interface IRepositorioClientes
    {
        List<ClienteListDto> GetClientesPorPagina(int cantidad, int paginaActual, string textoFiltro);
        List<ClienteListDto> GetClientes();
        int GetCantidad(string textoFiltro);
        bool Existe(Cliente cliente);
        void Agregar(Cliente cliente);
        void Editar(Cliente cliente);
        void Borrar(int clienteId);
        List<ClienteListDto> Filtrar(Pais pais);
        Cliente GetClientePorId(int clienteId);
        List<ClienteListDto> GetClientes(CiudadDto ciudadFiltro, Pais paisFiltro);
        List<ClienteComboDto> GetClienteComboDto();
    }
}
