using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Entidades.Dtos.Categoria;
using Dapper;

namespace Ejercicio2Jardines.Datos.Repositorios
{
    public class RepositorioCategorias : IRepositorioCategorias
    {

        private readonly string cadenaConexion;
        public RepositorioCategorias()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Categoria categoria)
        {

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string insertQuery = @"INSERT INTO Categorias (NombreCategoria) 
                    VALUES (@NombreCategoria); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, categoria);
                categoria.CategoriaId = id;
            }
        }
        public void Borrar(int categoriaId)
        {
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {

                    string deleteQuery = @"DELETE FROM Categorias 
                    WHERE CategoriaId=@CategoriaId";
                    conn.Execute(deleteQuery, new { categoriaId});
                }
            }

        }
        public void Editar(Categoria categoria)
        {

            using (var conn = new SqlConnection(cadenaConexion))
            {
               
                string updateQuery = @"UPDATE Categorias 
                    SET NombreCategoria=@NombreCategoria 
                    WHERE CategoriaId=@CategoriaId";
                conn.Execute(updateQuery, categoria);

            }

        }
        public List<Categoria> GetCategorias()
        {
            List<Categoria> lista = new List<Categoria>();

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT CategoriaId,NombreCategoria 
                    FROM Categorias";
                lista = conn.Query<Categoria>(selectQuery).ToList();
            }


            return lista;
        }
        public int GetCantidad()
        {

            int cantidad;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                
                string selectQuery = "SELECT COUNT(*) FROM Categorias";
                cantidad = conn.ExecuteScalar<int>(selectQuery);

                
            }
            return cantidad;
        }
        public bool Existe(Categoria categoria)
        {


            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (categoria.CategoriaId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Categorias WHERE NombreCategoria=@NombreCategoria";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, categoria);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Categorias WHERE NombreCategoria=@NombreCategoria AND CategoriaId<>@CategoriaId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, categoria);
                }


            }
            return cantidad > 0;


        }

        public List<Categoria> GetCategoriasPorPagina(int cantidadPorPagina, int paginaActual)
        {

            List<Categoria> lista = new List<Categoria>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                
                string selectQuery = @"SELECT CategoriaId, NombreCategoria 
                        FROM Categorias ORDER BY NombreCategoria
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                lista = conn.Query<Categoria>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
            }
            return lista;

        }



        public List<CategoriaComboDto> GetCategoriaComboDto()
        {
            try
            {
                List<CategoriaComboDto> lista = new List<CategoriaComboDto>();
                using (var conn = new SqlConnection(cadenaConexion))
                {

                    string selectQuery = @"SELECT CategoriaId, NombreCategoria 
                        FROM Categorias 
                        ORDER BY NombreCategoria";
                    lista = conn.Query<CategoriaComboDto>(selectQuery).ToList();
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionada(Categoria categoria)
        {
            int cantidad=0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                
                string selectQuery = @"SELECT COUNT(*) FROM Productos
                 WHERE CategoriaId=@CategoriaId";
                cantidad = conn.ExecuteScalar<int>(selectQuery,categoria);
            }
            return cantidad>0;
        }
    }
}
