using Ejercicio2Jardines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Interfaces
{
    public interface IServiciosPaises
    {
        List<Pais> GetPaises(string textoFiltro);
        List<Pais> GetPaisesPorPagina(int cantidad, int paginaActual,string textoFiltro);
        int GetCantidad(string textoFiltro);
        bool Existe(Pais pais);
        void Guardar(Pais pais);
        void Borrar(int paisId);
        
    }
}
