using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Entidades;
using System.Collections.Generic;

namespace Ejercicio2Jardines.Datos.Interfaces
{
    public interface IRepositorioCiudades
    {


        List<CiudadDto> GetCiudades(int? paisId);
        List<CiudadDto> GetCiudadesPorPagina(int cantidad, int paginaActual);
        int GetCantidad(int? PaisId);
        bool Existe(Ciudad ciudad);
        void Agregar(Ciudad ciudad);
        void Editar(Ciudad ciudad);
        void Borrar(int ciudadId);
        Ciudad GetCiudadPorId(int ciudadId);
    }
}
