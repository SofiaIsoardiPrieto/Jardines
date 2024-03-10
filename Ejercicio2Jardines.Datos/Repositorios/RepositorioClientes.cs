using Dapper;
using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Cliente;
using Ejercicio2Jardines.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Ejercicio2Jardines.Datos.Repositorios
{

    // Descripcion=reader[2]!=DBNull.Value? reader.GetString(2):string.Empty

    public class RepositorioClientes : IRepositorioClientes
    {
        private readonly string cadenaConexion;
        public RepositorioClientes()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public List<ClienteListDto> GetClientesPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            List<ClienteListDto> lista = new List<ClienteListDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT  c.ClienteId,c.Nombres,c.Apellido,p.NombrePais,ci.NombreCiudad
                      FROM Clientes c join Paises p on c.PaisId=p.PaisId
                        join Ciudades ci on c.CiudadId=ci.CiudadId
                      ORDER BY c.Apellido,c.Nombres
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<ClienteListDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT  c.ClienteId,c.Nombres,c.Apellido,p.NombrePais,ci.NombreCiudad
                      FROM Clientes c join Paises p on c.PaisId=p.PaisId
                        join Ciudades ci on c.CiudadId=ci.CiudadId
                      WHERE c.Apellido like @textoFiltro + '%'
                      ORDER BY c.Apellido,c.Nombres
                      OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<ClienteListDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
            }
            return lista;
        }
        public List<ClienteListDto> GetClientes()
        {
            List<ClienteListDto> lista = new List<ClienteListDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT c.ClienteId, c.Nombres, c.Apellido, p.NombrePais, ci.NombreCiudad 
                FROM Clientes c join Ciudades ci on c.CiudadId=ci.CiudadId
                join Paises p on c.PaisId=p.PaisId
                ORDER BY c.Apellido, c.Nombres";
                lista = conn.Query<ClienteListDto>(selectQuery).ToList();
            }
            return lista;
        }
        public int GetCantidad(string textoFiltro = null)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Clientes";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Clientes  WHERE Apellido LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
            }
            return cantidad;
        }

        public bool Existe(Cliente cliente)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery;
                if (cliente.ClienteId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Clientes
                        WHERE Nombres=@Nombres AND Apellido=@Apellido";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, cliente);
                }
                else
                {
                    //que tenga distinto id de cliente
                    selectQuery = @"SELECT COUNT(*) FROM Clientes 
                        WHERE Nombres=@Nombres AND Apellido=@Apellido AND ClienteId!=@ClienteId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, cliente);
                }
            }
            return cantidad > 0;
        }
        public void Agregar(Cliente cliente)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string addQuery = @"INSERT INTO Clientes (Nombres, Apellido,                                     
                                Direccion, CodigoPostal, PaisId, CiudadId, Email)
                                VALUES (@Nombres, @Apellido, @Direccion,
                                @CodigoPostal, @PaisId, @CiudadId, @Email)
                                SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(addQuery, cliente);
                cliente.ClienteId = id;
            }
        }
        public void Editar(Cliente cliente)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string updateQuery = @"UPDATE Clientes SET Nombres=@Nombres,
                                Apellido=@Apellido, Direccion=@Direccion, 
                                CodigoPostal=@CodigoPostal, PaisId=@PaisId, 
                                CiudadId=@CiudadId, Email=@Email                                 
                                WHERE ClienteId=@ClienteId";
                conn.Execute(updateQuery, cliente);
            }
        }
        public void Borrar(int clienteId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Clientes WHERE ClienteId=@ClienteId";

                conn.Execute(deleteQuery, clienteId);

            }
        }
        public List<ClienteListDto> Filtrar(Pais pais)
        {
            List<ClienteListDto> lista = new List<ClienteListDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT c.ClienteId, c.Nombres, c.Apellido, p.NombrePais, ci.NombreCiudad
                FROM Clientes c join Ciudades ci on c.CiudadId = ci.CiudadId
                join Paises p on c.PaisId = p.PaisId
                WHERE PaisId = @PaisId
                ORDER BY p.NombrePais, ci.NombreCiudad";
                lista = conn.Query<ClienteListDto>(selectQuery, new { pais.PaisId }).ToList();
            }
            return lista;
        }
        public Cliente GetClientePorId(int clienteId)
        {
            Cliente cliente = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                //????????????
                string selectQuery = @"SELECT ClienteId, Nombres, Apellido, Direccion, CodigoPostal, PaisId, CiudadId 
                        FROM Clientes WHERE ClienteId=@ClienteId";
                cliente = conn.QuerySingle<Cliente>(selectQuery, new { ClienteId = clienteId });
            }
            return cliente;
        }
        public List<ClienteListDto> GetClientes(CiudadDto ciudadFiltro, Pais paisFiltro)
        {
            List<ClienteListDto> lista = new List<ClienteListDto>();

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT  c.ClienteId,c.Nombres,c.Apellido,p.NombrePais,ci.NombreCiudad
                         FROM Clientes c join Paises p on c.PaisId=p.PaisId
                        join Ciudades ci on c.CiudadId=ci.CiudadId
                        WHERE c.PaisId=@PaisId AND c.CiudadId=@CiudadId
                        ORDER BY Apellido, Nombres";
                lista = conn.Query<ClienteListDto>(selectQuery, new { paisFiltro.PaisId, ciudadFiltro.CiudadId }).ToList();
            }
            return lista;
        }
        public List<ClienteComboDto> GetClienteComboDto()
        {
            List<ClienteComboDto> lista = new List<ClienteComboDto>();

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT ClienteId,CONCAT( Apellido,Nombres) as NombreCompleto
                            FROM Clientes
                            ORDER BY NombreCompleto";
                lista = conn.Query<ClienteComboDto>(selectQuery).ToList();
            }
            return lista;
        }
    }
}
