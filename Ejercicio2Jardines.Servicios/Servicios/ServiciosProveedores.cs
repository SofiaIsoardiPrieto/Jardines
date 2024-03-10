using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Datos.Repositorios;
using Ejercicio2Jardines.Datos;
using Ejercicio2Jardines.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Proveedor;

namespace Ejercicio2Jardines.Servicios.Servicios
{
    public class ServiciosProveedores: IServiciosProveedores
    {
        private readonly IRepositorioProveedores _repositorio;
        private readonly IRepositorioCiudades _repoCiudades;
        private readonly IRepositorioPaises _repoPaises;

        public ServiciosProveedores()
        {
            _repositorio = new RepositorioProveedores();
            _repoCiudades = new RepositorioCiudades();
            _repoPaises = new RepositorioPaises();
        }

        public void Borrar(int proveedorId)
        {
            try
            {
                _repositorio.Borrar(proveedorId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            try
            {
               return _repositorio.Existe(proveedor);
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

        public List<ProveedorDto> GetProveedores(CiudadDto ciudadFiltro, Pais paisFiltro)
        {
            try
            {
                return _repositorio.GetProveedores(ciudadFiltro, paisFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProveedorComboDto> GetProveedoresComboDto()
        {
            try
            {
                return _repositorio.GetProveedoresComboDto();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProveedorDto> GetProveedoresPorPagina(int registrosPorPagina, int paginaActual, string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetProveedoresPorPagina(registrosPorPagina, paginaActual, textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Proveedor GetProveedorPorId(int proveedorId)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Proveedor proveedor)
        {

            try
            {
                if (proveedor.ProveedorId == 0)
                {
                    _repositorio.Agregar(proveedor);

                }
                else
                {
                    _repositorio.Editar(proveedor);
                }
            }
            catch (Exception) { throw; }
        }
    }
}
