using Dapper;
using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Ejercicio2Jardines.Datos
{
    public class RepositorioPaises : IRepositorioPaises
    {
        private readonly string cadenaConexion;
        public RepositorioPaises()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public List<Pais> GetPaises(string textoFiltro = null)
        {

            List<Pais> lista = new List<Pais>();
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery;
                if (textoFiltro != null)
                {
                    selectQuery = @"SELECT PaisId, NombrePais 
                    FROM Paises WHERE NombrePais LIKE @textoFiltro ORDER BY NombrePais";
                    textoFiltro = $"{textoFiltro}%";
                    lista = conn.Query<Pais>(selectQuery, new { textoFiltro }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT PaisId, NombrePais 
                    FROM Paises ORDER BY NombrePais";
                    lista = conn.Query<Pais>(selectQuery).ToList();
                }



            }
            return lista;

        }
        public void Agregar(Pais pais)
        {

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string insertQuery = @"INSERT INTO Paises (NombrePais) 
                    VALUES(@NombrePais); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, pais);
                pais.PaisId = id;

            }
        }
        public void Borrar(int paisId)
        {

            using (var conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string deleteQuery = "DELETE FROM Paises WHERE PaisId=@PaisId";
                conn.Execute(deleteQuery, new { paisId });

            }

        }
        public void Editar(Pais pais)
        {
            
                using (var conn = new SqlConnection(cadenaConexion))
                {

                    string updateQuery = @"UPDATE Paises SET NombrePais=@NombrePais 
                    WHERE PaisId=@PaisId";
                    conn.Execute(updateQuery, pais);

                }
           
        }
        public int GetCantidad(string textoFiltro = null)
        {
            
                int cantidad = 0;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    string selectQuery;
                    if (textoFiltro == null)
                    {
                        selectQuery = "SELECT COUNT(*) FROM Paises";
                        cantidad = conn.ExecuteScalar<int>(selectQuery);
                    }
                    else
                    {
                        selectQuery = @"SELECT COUNT(*) FROM Paises
                                       WHERE NombrePais LIKE @textoFiltro+ '%'";
                        cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                    }

                }
                return cantidad;

           
        }
        public bool Existe(Pais pais)
        {
           
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (pais.PaisId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Paises WHERE NombrePais=@NombrePais";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, pais);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Paises WHERE NombrePais=@NombrePais AND PaisId<>@PaisId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, pais);
                }
            }
            return cantidad > 0;


        }   
        public List<Pais> GetPaisesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            try
            {
                List<Pais> lista = new List<Pais>();
                using (var conn = new SqlConnection(cadenaConexion))
                {

                    string selectQuery;
                    if (textoFiltro == null)
                    {
                        selectQuery = @"SELECT PaisId, NombrePais 
                        FROM Paises
                        ORDER BY NombrePais
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                        var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                        lista = conn.Query<Pais>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                    }
                    else
                    {
                        selectQuery = @"SELECT PaisId, NombrePais 
                        FROM Paises
                        WHERE NombrePais like @textoFiltro+ '%'
                        ORDER BY NombrePais
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                        var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                        lista = conn.Query<Pais>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                    }

                }
                return lista;
            }
            catch (Exception) { throw; }

        }


    }
}
