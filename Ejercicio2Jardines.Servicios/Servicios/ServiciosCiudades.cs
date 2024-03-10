using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Datos;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Datos.Repositorios;
using Ejercicio2Jardines.Entidades;
using System.Collections;
using Ejercicio2Jardines.Entidades.Dtos;

namespace Ejercicio2Jardines.Servicios.Servicios
{
    public class ServiciosCiudades: IServiciosCiudades
    {

        private readonly IRepositorioCiudades _repositorio;
        private readonly IRepositorioPaises _repoPaises;
        public ServiciosCiudades()
        {
            _repositorio = new RepositorioCiudades();
            _repoPaises = new RepositorioPaises();
        }
       
        
        public List<CiudadDto> GetCiudades(int? paisId)
        {
            try
            {
               return  _repositorio.GetCiudades(paisId);

                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CiudadDto> GetCiudadesPorPagina(int cantidad, int paginaActual)
        {
            try
            {
                return  _repositorio.GetCiudadesPorPagina(cantidad, paginaActual);
                
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int GetCantidad(int? PaisId)
        {
            try
            {
                return _repositorio.GetCantidad(PaisId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public bool Existe(Ciudad ciudad)
        {
            try
            {
                return _repositorio.Existe(ciudad);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Guardar(Ciudad ciudad)
        {
            try
            {
                if (ciudad.CiudadId == 0)
                {
                    _repositorio.Agregar(ciudad);

                }
                else
                {
                    _repositorio.Editar(ciudad);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public void Borrar(int ciudadId)
        {
            try
            {
                _repositorio.Borrar(ciudadId);
            }
            catch (Exception)
            {

                throw;
            }
        }
        

       

        
    }
}

