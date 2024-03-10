using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Entidades;
using System.Collections.Generic;

namespace Ejercicio2Jardines.Servicios.Interfaces
{
    public interface IServiciosCiudades
    {

        List<CiudadDto> GetCiudades(int? paisId);
        List<CiudadDto> GetCiudadesPorPagina(int cantidad, int paginaActual);
        int GetCantidad(int? PaisId);
        bool Existe(Ciudad ciudad);
        void Guardar(Ciudad ciudad);
        void Borrar(int ciudadId);



    }
}
