using Ejercicio2Jardines.Entidades.Dtos.Categoria;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Interfaces
{
    public interface IServiciosCategorias
    {
        List<Categoria> GetCategorias();
        List<Categoria> GetCategoriaPorPagina(int cantidad, int paginaActual);
        int GetCantidad();
        bool Existe(Categoria categoria);
        void Guardar(Categoria categoria);
        void Borrar(int categoriaId);
        List<CategoriaComboDto> GetCategoriaComboDto();
    }
}
