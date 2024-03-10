using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Datos.Interfaces
{
    public interface IRepositorioCategorias
    {
        List<Categoria> GetCategorias();
        List<Categoria> GetCategoriasPorPagina(int cantidad, int paginaActual);
        int GetCantidad();
        bool Existe(Categoria categoria);
        void Agregar(Categoria categoria);
        void Editar(Categoria categoria);
        void Borrar(int categoriaId);





    }
}
