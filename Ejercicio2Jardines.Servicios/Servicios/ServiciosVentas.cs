using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Datos.Repositorios;
using Ejercicio2Jardines.Entidades.Dtos.Venta;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Servicios
{
    public class ServiciosVentas:IServiciosVentas
    {

        private readonly IRepositorioVentas _repositorio;
        public ServiciosVentas()
        {
            _repositorio = new RepositorioVentas();
        }

        public bool Existe(Venta venta)
        {
            try
            {
                return _repositorio.Existe(venta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(DateTime? fechaFiltro = null, string textoFiltro = null)
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



        public List<VentaDto> GetVentas(Cliente cienteFiltro = null)
        {
            try
            {
                return _repositorio.GetVentas(cienteFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<VentaDto> GetVentasPorPagina(int registrosPorPagina, int paginaActual, DateTime? fechaFiltro = null, string textoFiltro = null)
        {
            try
            {
                return _repositorio.GetVentasPorPagina(registrosPorPagina, paginaActual, fechaFiltro, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }



        public void Guardar(Venta venta)
        {
            try
            {
                _repositorio.Guardar(venta);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

