using Ejercicio2Jardines.Datos;
using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using System;
using System.Collections.Generic;

namespace Ejercicio2Jardines.Servicios
{
    public class ServiciosPaises:IServiciosPaises
    {

        private readonly IRepositorioPaises _repositorio;
        public ServiciosPaises()
        {
            _repositorio = new RepositorioPaises();
        }
        public List<Pais> GetPaises(string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetPaises(textoFiltro);
            }
            catch (Exception) { throw; }
        }
        public List<Pais> GetPaisesPorPagina(int cantidad, int paginaActual, string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetPaisesPorPagina(cantidad, paginaActual, textoFiltro);
            }
            catch (Exception) { throw; }
        }

        public bool Existe(Pais pais)
        {
            try
            {
                return _repositorio.Existe(pais);
            }
            catch (Exception) { throw; }
        }

        public void Guardar(Pais pais)
        {
            try
            {
                if (pais.PaisId == 0)
                {
                    _repositorio.Agregar(pais);

                }
                else
                {
                    _repositorio.Editar(pais);
                }
            }
            catch (Exception) { throw; }
        }
        public void Borrar(int paisId)
        {
            try
            {
                _repositorio.Borrar(paisId);
            }
            catch (Exception) { throw; }
            
        }
        public int GetCantidad(string textoFiltro=null)
        {
            try
            {
                return _repositorio.GetCantidad(textoFiltro);
            }
            catch (Exception) { throw; }
        }
    }
}

