using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Compra;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Dapper;

namespace Ejercicio2Jardines.Datos.Repositorios
{
    public class RepositorioCompras:IRepositorioCompras
    {
        private readonly string cadenaConexion;
        public RepositorioCompras()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public bool Existe(Compra compra)
        {
            try
            {
                var cantidad = 0;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery;
                    if (compra.CompraId == 0)
                    {
                        selectQuery = @"SELECT COUNT(*) FROM Compras
                        WHERE FechaCompra=@FechaCompra AND ProveedorId=@ProveedorId";

                    }
                    else
                    {
                        //que tenga distinto id de compra
                        selectQuery = @"SELECT COUNT(*) FROM Compras 
                        WHERE FechaCompra=@FechaCompra AND ProveedorId=@ProveedorId AND CompraId!=@CompraId";

                    }
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        comando.Parameters.Add("@FechaCompra", SqlDbType.NVarChar);
                        comando.Parameters["@FechaCompra"].Value = compra.FechaCompra;

                        comando.Parameters.Add("@ProveedorId", SqlDbType.NVarChar);
                        comando.Parameters["@ProveedorId"].Value = compra.ProveedorId;

                        if (compra.CompraId!= 0)
                        {
                            comando.Parameters.Add("@CompraId", SqlDbType.Int);
                            comando.Parameters["@CompraId"].Value = compra.CompraId;

                        }

                        cantidad = (int)comando.ExecuteScalar();
                    }
                }
                return cantidad > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(DateTime? fechaFiltro =null, string textoFiltro=null)
        {
            try
            {
                int cantidad = 0;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery;
                    if (fechaFiltro == null)
                    {
                        selectQuery = "SELECT COUNT(*) FROM Compras";
                    }
                    else
                    {
                        selectQuery = @"SELECT COUNT(*) FROM Compras
                                       WHERE FechaCompra LIKE @fechaFiltro";
                    }
                    if (textoFiltro!=null)
                    {
                        selectQuery = @"SELECT COUNT(*) FROM Compras
                                       WHERE NombreProveedor LIKE @textoFiltro";
                    }
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        if (fechaFiltro != null)
                        {
                            comando.Parameters.Add("@fechaFiltro", SqlDbType.NVarChar);
                            comando.Parameters["@fechaFiltro"].Value = $"{fechaFiltro}%";
                        }
                        if (textoFiltro != null)
                        {
                            comando.Parameters.Add("@textoFiltro", SqlDbType.NVarChar);
                            comando.Parameters["@textoFiltro"].Value = $"{textoFiltro}%";
                        }

                        cantidad = (int)comando.ExecuteScalar();
                    }
                }
                return cantidad;

            }
            catch (Exception) { throw; }
        }

       

        public List<CompraDto> GetCompras(Proveedor proveedorFiltro=null)
        {
            throw new NotImplementedException();
        }

        public List<CompraDto> GetComprasPorPagina(int cantidad, int paginaActual, DateTime? fechaFiltro =null,string textoFiltro=null )
        {
            try
            {
                List<CompraDto> lista = new List<CompraDto>();
               
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery;
                    if (textoFiltro!=null)
                    {
                        selectQuery = @"SELECT c.CompraId, c.FechaCompra,p.NombreProveedor,c.Total  
                        FROM Compras c join Proveedores p on c.ProveedorId=p.ProveedorId
                        WHERE p.NombreProveedor like @fechaFiltro
                        ORDER BY p.NombreProveedor
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";

                    }
                    if (fechaFiltro == null)
                    {
                        selectQuery = @"SELECT c.CompraId, c.FechaCompra,p.NombreProveedor,c.Total 
                            FROM Compras c join Proveedores p on c.ProveedorId=p.ProveedorId
                            ORDER BY c.FechaCompra
                            OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    }
                    else
                    {
                        selectQuery = @"SELECT c.CompraId, c.FechaCompra,p.NombreProveedor,c.Total  
                        FROM Compras c join Proveedores p on c.ProveedorId=p.ProveedorId
                        WHERE CAST(c.FechaCompra AS DATE) = @fechaFiltro
                        ORDER BY c.FechaCompra
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    }
                    using (var cmd = new SqlCommand(selectQuery, conn))
                    {
                        if (fechaFiltro != null)
                        {
                            cmd.Parameters.Add("@fechaFiltro", SqlDbType.NVarChar);
                            cmd.Parameters["@fechaFiltro"].Value = fechaFiltro;
                        }
                        if (textoFiltro!=null)
                        {
                            cmd.Parameters.Add("@textoFiltro", SqlDbType.NVarChar);
                            cmd.Parameters["@textoFiltro"].Value = fechaFiltro;
                        }
                        cmd.Parameters.Add("@cantidadRegistros", SqlDbType.Int);
                        cmd.Parameters["@cantidadRegistros"].Value = cantidad * (paginaActual - 1);
                        cmd.Parameters.Add("@cantidadPorPagina", SqlDbType.Int);
                        cmd.Parameters["@cantidadPorPagina"].Value = cantidad;
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var compra = ConstruirCompra(reader);
                                lista.Add(compra);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception) { throw; }
        }

        private CompraDto ConstruirCompra(SqlDataReader reader)
        {
            return new CompraDto()
            {
                CompraId = reader.GetInt32(0),
                FechaCompra = reader.GetDateTime(1),
                NombreProveedor=reader.GetString(2),
                Total=reader.GetDecimal(3)
            };
        }

        public void Guardar(Compra compra)
        {
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO Compras (FechaCompra, ProveedorId, Total)
                                VALUES (@FechaCompra, @ProveedorId, @Total);
                                SELECT SCOPE_IDENTITY()";
                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.Add("@FechaCompra", SqlDbType.DateTime);
                        cmd.Parameters["@FechaCompra"].Value = compra.FechaCompra;

                        cmd.Parameters.Add("@ProveedorId", SqlDbType.Int);
                        cmd.Parameters["@ProveedorId"].Value = compra.ProveedorId;

                        cmd.Parameters.Add("@Total", SqlDbType.Decimal);
                        cmd.Parameters["@Total"].Value = compra.Total;

                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        compra.CompraId = id;
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }

        }
    }
}
