using Dapper;
using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Cliente;
using Ejercicio2Jardines.Entidades.Dtos.Proveedor;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Ejercicio2Jardines.Datos.Repositorios
{
    public class RepositorioProveedores : IRepositorioProveedores
    {
        private readonly string cadenaConexion;
        public RepositorioProveedores()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Proveedor proveedor)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string addQuery = @"INSERT INTO Proveedores (NombreProveedor,                                      
                                Direccion, CodigoPostal, CiudadId,  PaisId)
                                VALUES (@NombreProveedor, @Direccion,
                                @CodigoPostal, @CiudadId, @PaisId)
                                SELECT SCOPE_IDENTITY()";

                int id = conn.QuerySingle<int>(addQuery, proveedor);
                proveedor.ProveedorId = id;
            }
        }

        public void Borrar(int proveedorId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string deleteQuery = "DELETE FROM Proveedores WHERE ProveedorId=@ProveedorId";
                conn.Execute(deleteQuery);
            }

        }
        public void Editar(Proveedor proveedor)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Prooderes SET NombreProveedor=@NombreProveedor,
                                Direccion=@Direccion, 
                                CodigoPostal=@CodigoPostal, CiudadId=@CiudadId,PaisId=@PaisId, 
                                Email=@Email , TelefonoFijo=@TelefonoFijo , TelefonoMovil=@TelefonoMovil                    
                                WHERE ProovedorId=@ProovedorId";
                conn.Execute(updateQuery, proveedor);
            }
        }
        public bool Existe(Proveedor proveedor)
        {

            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery;
                if (proveedor.ProveedorId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Proveedores
                        WHERE NombreProveedor=@NombreProveedor ";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, proveedor);
                }
                else
                {
                    //que tenga distinto id de proveedor
                    selectQuery = @"SELECT COUNT(*) FROM Proveedors 
                        WHERE NombreProveedor=@NombreProveedor AND ProveedorId!=@ProveedorId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, proveedor);
                }
            }
            return cantidad > 0;
        }
        public int GetCantidad(string textoFiltro = null)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = "SELECT COUNT(*) FROM Proveedores";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Proveedores
                                       WHERE NombreProveedor LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
            }
            return cantidad;
        }

        public List<ProveedorComboDto> GetProveedoresComboDto()
        {
            try
            {
                List<ProveedorComboDto> lista = new List<ProveedorComboDto>();
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery = @"SELECT ProveedorId, NombreProveedor
                            FROM Proveedores
                            ORDER BY NombreProveedor";
                    lista = conn.Query<ProveedorComboDto>(selectQuery).ToList();
                }
                return lista;
            }
            catch (Exception) { throw; }
        }
        public List<ProveedorDto> GetProveedoresPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {

            List<ProveedorDto> lista = new List<ProveedorDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery =
                        @"SELECT p.ProveedorId,p.NombreProveedor,c.NombreCiudad,pa.NombrePais
                            FROM Proveedores p join Ciudades c on p.CiudadId=c.CiudadId
                            join Paises pa on p.PaisId=pa.PaisId
                            ORDER BY p.NombreProveedor
                            OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<ProveedorDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery =
                        @"SELECT p.ProveedorId,p.NombreProveedor,c.NombreCiudad,pa.NombrePais
                             FROM Proveedores p join Ciudades c on p.CiudadId=c.CiudadId
                             join Paises pa on p.PaisId=pa.PaisId
                             WHERE NombreProveedor like @textoFiltro + '%'
                             ORDER BY p.NombreProveedor
                             OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<ProveedorDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }

            }
            return lista;
        }

        
        public List<ProveedorDto> GetProveedores(CiudadDto ciudadFiltro, Pais paisFiltro)
        {
            List<ProveedorDto> lista = new List<ProveedorDto>();

            using (var conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string selectQuery = @"SELECT pro.ProveedorId,pro.NombreProveedor,p.NombrePais,c.NombreCiudad
                        FROM Proveedores pro join Paises p on pro.PaisId=p.PaisId
                         join Ciudades c on pro.CiudadId=c.CiudadId
                        WHERE p.PaisId=@PaisId AND c.CiudadId=@CiudadId
                        ORDER BY pro.NombreProveedor";
                lista = conn.Query<ProveedorDto>(selectQuery, new { paisFiltro.PaisId, ciudadFiltro.CiudadId }).ToList();
            }
            return lista;
        }
    }
}
