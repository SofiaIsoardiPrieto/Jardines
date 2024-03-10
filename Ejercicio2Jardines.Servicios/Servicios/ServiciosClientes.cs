using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Datos.Repositorios;
using Ejercicio2Jardines.Datos;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2Jardines.Entidades.Dtos.Cliente;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;

namespace Ejercicio2Jardines.Servicios.Servicios
{
    public class ServiciosClientes : IServiciosClientes
    {
        private readonly IRepositorioClientes _repositorio;
        private readonly IRepositorioCiudades _repoCiudades;
        private readonly IRepositorioPaises _repoPaises;
       
        public ServiciosClientes()
        {
            _repositorio = new RepositorioClientes();
            _repoCiudades = new RepositorioCiudades();
            _repoPaises = new RepositorioPaises();
        }
        public List<ClienteListDto> GetClientes()
        {
            try
            {
                return _repositorio.GetClientes();
                //var listaClientes = _repositorio.GetClientes();
                //foreach (var item in listaClientes)
                //{
                //    var pais = _repoPaises.GetPaisPorId(item.PaisId);
                //    var ciudad = _repoCiudades.GetCiudadPorId(item.CiudadId);
                //    item.NombrePais = pais.NombrePais;
                //    item.NombreCiudad = ciudad.NombreCiudad;
                //}
                //return listaClientes;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public List<ClienteListDto> GetClientesPorPagina(int cantidad, int paginaActual, string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetClientesPorPagina(cantidad, paginaActual, textoFiltro);
                //var lista = _repositorio.GetClientesPorPagina(cantidad, paginaActual);
                //foreach (var item in lista)
                //{
                //    var pais = _repoPaises.GetPaisPorId(item.PaisId);
                //    var ciudad = _repoCiudades.GetCiudadPorId(item.CiudadId);
                //    item.NombrePais = pais.NombrePais;
                //    item.NombreCiudad = ciudad.NombreCiudad;
                //}
                //return lista;
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
        public bool Existe(Cliente cliente)
        {
            try
            {
                return _repositorio.Existe(cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Cliente cliente)
        {
            try
            {
                if (cliente.ClienteId == 0)
                {
                    _repositorio.Agregar(cliente);
                }
                else
                {
                    _repositorio.Editar(cliente);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void Borrar(int clienteId)
        {
            try
            {
                _repositorio.Borrar(clienteId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Cliente GetClientePorId(int clienteId)
        {
            try
            {
                return _repositorio.GetClientePorId(clienteId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ClienteListDto> Filtrar(Pais pais)
        {
            try
            {
                return _repositorio.Filtrar(pais);
                
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        
    public List<ClienteListDto> GetClientes(CiudadDto ciudadFiltro, Pais paisFiltro)
    {
            try
            {
                return _repositorio.GetClientes(ciudadFiltro, paisFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ClienteComboDto> GetClienteComboDto()
        {
            try
            {
                return _repositorio.GetClienteComboDto();
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
