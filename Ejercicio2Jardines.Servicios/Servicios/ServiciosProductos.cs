using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2Jardines.Datos.Repositorios;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Entidades.Dtos.Producto;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Entidades;

namespace Ejercicio2Jardines.Servicios.Servicios
{
    public class ServiciosProductos:IServiciosProductos
    {
        private readonly IRepositorioProductos _repositorio;
        public ServiciosProductos()
        {
            _repositorio = new RepositorioProductos();
        }

        public void Borrar(int productoId)
        {
            try
            {
                 _repositorio.Borrar(productoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Producto producto)
        {
            try
            {
                return _repositorio.Existe(producto);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetCantidad(textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Producto GetProductosPorId(int productoId)
        {
            try
            {
                return _repositorio.GetProductosPorId(productoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProductoDto> GetProductosPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetProductosPorPagina(registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Producto producto)
        {
            try
            {
                if (producto.ProductoId == 0)
                {
                    _repositorio.Agregar(producto);

                }
                else
                {
                    _repositorio.Editar(producto);
                }
            }
            catch (Exception) { throw; }
        }
    }
}
