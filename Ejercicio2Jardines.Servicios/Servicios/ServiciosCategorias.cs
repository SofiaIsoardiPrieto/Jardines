using Ejercicio2Jardines.Datos;
using Ejercicio2Jardines.Datos.Repositorios;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Categoria;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Jardines.Servicios.Servicios
{
    public class ServiciosCategorias: IServiciosCategorias
    {
        private readonly RepositorioCategorias _repositorio;

        public ServiciosCategorias()
        {
            _repositorio = new RepositorioCategorias();
        }
        public List<Categoria> GetCategorias()
        {
            try
            {
                return _repositorio.GetCategorias();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Categoria> GetCategoriaPorPagina(int cantidad, int paginaActual)
        {
            try
            {
                return _repositorio.GetCategoriasPorPagina(cantidad, paginaActual);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int GetCantidad()
        {
            try
            {
                return _repositorio.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Existe(Categoria categoria)
        {
            try
            {
                return _repositorio.Existe(categoria);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Guardar(Categoria categoria)
        {
            try
            {
                if (categoria.CategoriaId == 0)
                {
                    _repositorio.Agregar(categoria);

                }
                else
                {
                    _repositorio.Editar(categoria);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Borrar(int CategoriaId)
        {
            try
            {
                _repositorio.Borrar(CategoriaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CategoriaComboDto> GetCategoriaComboDto()
        {
            try
            {
                return _repositorio.GetCategoriaComboDto();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
