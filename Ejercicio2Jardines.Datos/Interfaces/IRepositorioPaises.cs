using Ejercicio2Jardines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Datos.Interfaces
{
    public interface IRepositorioPaises
    {
        List<Pais> GetPaises(string textoFiltro);
        List<Pais> GetPaisesPorPagina(int cantidad, int paginaActual,string textoFiltro);
        bool Existe(Pais pais);
        void Agregar(Pais pais);
        void Editar(Pais pais);
        void Borrar(int paisId);
       
       
        int GetCantidad(string textoFiltro);
    }
}
