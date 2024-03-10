using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Dapper;
using Ejercicio2Jardines.Entidades.Dtos;

namespace Ejercicio2Jardines.Datos.Repositorios
{
    public class RepositorioCiudades : IRepositorioCiudades
    {

        private readonly string cadenaConexion;
        public RepositorioCiudades()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public List<Ciudad> GetCiudades()
        {
            List<Ciudad> lista = new List<Ciudad>();
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT CiudadId, NombreCiudad, PaisId 
                    FROM Ciudades ORDER BY PaisId, NombreCiudad";
                lista = conn.Query<Ciudad>(selectQuery).ToList();
            }
            return lista;
        }
        public List<CiudadDto> GetCiudades(int? paisId)
        {
            List<CiudadDto> lista = new List<CiudadDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (paisId == null)
                {
                    selectQuery = @"SELECT c.CiudadId, c.NombreCiudad, p.NombrePais 
                    FROM Ciudades c join Paises p on c.PaisId=p.PaisId
					ORDER BY NombrePais, NombreCiudad";
                    lista = conn.Query<CiudadDto>(selectQuery).ToList();
                }
                else
                {
                    selectQuery = @"SELECT c.CiudadId, c.NombreCiudad, p.NombrePais 
                    FROM Ciudades c join Paises p on c.PaisId=p.PaisId
                    WHERE c.PaisId=@PaisId
					ORDER BY NombrePais, NombreCiudad";
                    lista = conn.Query<CiudadDto>(selectQuery, new { PaisId = paisId }).ToList();
                }
            }
            return lista;
        }
        public List<CiudadDto> GetCiudadesPorPagina(int cantidadPorPagina, int paginaActual)
        {
            List<CiudadDto> lista = new List<CiudadDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT CiudadId, NombreCiudad, p.NombrePais 
                    FROM Ciudades c join Paises p on c.PaisId=p.PaisId
					ORDER BY NombrePais, NombreCiudad
                    OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                lista = conn.Query<CiudadDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();   
            }
            return lista;
        }
        public void Agregar(Ciudad ciudad)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Ciudades (NombreCiudad, PaisId) 
                        VALUES(@NombreCiudad,@PaisId); SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, ciudad);
                ciudad.CiudadId = id;
            }
        }
        public void Borrar(int ciudadId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = @"DELETE FROM Ciudades 
                        WHERE CiudadId=@CiudadId";
                conn.Execute(deleteQuery, new { ciudadId });
            }
        }
        public void Editar(Ciudad ciudad)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Ciudades 
                       SET NombreCiudad=@NombreCiudad, PaisId=@PaisId 
                       WHERE CiudadId=@CiudadId";
                conn.Execute(updateQuery, ciudad);
            }
        }
        public bool Existe(Ciudad ciudad)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (ciudad.CiudadId == 0)
                {
                    //cuando es nuevo la ciudad y hay que agregar, ver si ya existe.

                    selectQuery = @"SELECT COUNT(*) FROM Ciudades 
                            WHERE NombreCiudad=@NombreCiudad AND PaisId=@PaisId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, ciudad);
                }
                else
                {
                    //cuando es una edicion y veo si ya existe la ciudad.

                    selectQuery = @"SELECT COUNT(*) FROM Ciudades 
                           WHERE NombreCiudad=@NombreCiudad AND PaisId=@PaisId 
                            AND CiudadId!=@CiudadId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, ciudad);
                }               
            }
            return cantidad > 0;
        }
        //Queda en veremos...
        public List<Ciudad> Filtrar(Pais pais)
        {
            List<Ciudad> lista = new List<Ciudad>();

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT CiudadId, NombreCiudad, PaisId 
                        FROM Ciudades WHERE PaisId=@PaisId ORDER BY PaisId, NombreCiudad";
                lista = conn.Query<Ciudad>(selectQuery, pais).ToList();
            }
            return lista;
        }

        public int GetCantidad(int? paisId)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {               
                string selectQuery;
                if (paisId == null)
                {
                    selectQuery = "SELECT COUNT(*) FROM Ciudades";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Ciudades WHERE PaisId=@PaisId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { PaisId = paisId });
                }          
            }
            return cantidad;
        }
        public Ciudad GetCiudadPorId(int ciudadId)
        {
            Ciudad ciudad = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT CiudadId, NombreCiudad, PaisId FROM Ciudades WHERE CiudadId=@CiudadId";
                conn.QuerySingle<Ciudad>(selectQuery, ciudadId);
            }
            return ciudad;
        }
    }
}

