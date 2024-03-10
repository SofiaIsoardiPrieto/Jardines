using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Datos.Repositorios;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Compra;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Servicios
{
    public class ServiciosCompras:IServiciosCompras
    {
        private readonly IRepositorioCompras _repositorio;
        public ServiciosCompras()
        {
            _repositorio = new RepositorioCompras();
        }

        public bool Existe(Compra compra)
        {
            try
            {
                return _repositorio.Existe(compra);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(DateTime? fechaFiltro =null, string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetCantidad(fechaFiltro, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

       

        public List<CompraDto> GetCompras(Proveedor proveedorFiltro=null)
        {
            try
            {
                return _repositorio.GetCompras(proveedorFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CompraDto> GetComprasPorPagina(int registrosPorPagina, int paginaActual, DateTime? fechaFiltro =null, string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetComprasPorPagina(registrosPorPagina,paginaActual, fechaFiltro, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

      

        public void Guardar(Compra compra)
        {
            try
            {
                _repositorio.Guardar(compra);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
