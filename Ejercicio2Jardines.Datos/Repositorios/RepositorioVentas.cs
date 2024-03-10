using Ejercicio2Jardines.Entidades.Dtos.Venta;
using Ejercicio2Jardines.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio2Jardines.Datos.Interfaces;
using Dapper;

namespace Ejercicio2Jardines.Datos.Repositorios
{
    public class RepositorioVentas:IRepositorioVentas
    {
        private readonly string cadenaConexion;
        public RepositorioVentas()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public bool Existe(Venta venta)
        {
            try
            {
                var cantidad = 0;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery;
                    if (venta.VentaId == 0)
                    {
                        selectQuery = @"SELECT COUNT(*) FROM Ventas
                        WHERE FechaVenta=@FechaVenta AND ClienteId=@ClienteId";

                    }
                    else
                    {
                        //que tenga distinto id de venta
                        selectQuery = @"SELECT COUNT(*) FROM Ventas 
                        WHERE FechaVenta=@FechaVenta AND ClienteId=@ClienteId AND VentaId!=@VentaId";

                    }
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        comando.Parameters.Add("@FechaVenta", SqlDbType.NVarChar);
                        comando.Parameters["@FechaVenta"].Value = venta.FechaVenta;

                        comando.Parameters.Add("@ClienteId", SqlDbType.NVarChar);
                        comando.Parameters["@ClienteId"].Value = venta.ClienteId;

                        if (venta.VentaId != 0)
                        {
                            comando.Parameters.Add("@VentaId", SqlDbType.Int);
                            comando.Parameters["@VentaId"].Value = venta.VentaId;

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

        public int GetCantidad(DateTime? fechaFiltro = null, string textoFiltro = null)
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
                        selectQuery = "SELECT COUNT(*) FROM Ventas";
                    }
                    else
                    {
                        selectQuery = @"SELECT COUNT(*) FROM Ventas
                                       WHERE FechaVenta LIKE @fechaFiltro";
                    }
                    if (textoFiltro != null)
                    {
                        selectQuery = @"SELECT COUNT(*) FROM Ventas
                                       WHERE Apellido LIKE @textoFiltro";
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
        public List<VentaDto> GetVentasPorPagina(int cantidad, int paginaActual, DateTime? fechaFiltro = null, string textoFiltro = null)
        {
            try
            {
                List<VentaDto> lista = new List<VentaDto>();

                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery;
                    if (textoFiltro != null)
                    {
                        selectQuery = @"SELECT v.VentaId, v.FechaVenta,CONCAT(c.Apellido, ', ', c.Nombres) AS NombreCliente,v.Total 
                        FROM Ventas v join Clientes c on v.ClienteId=c.ClienteId
                        WHERE CONCAT(c.Apellido, ', ', c.Nombres) like @fechaFiltro
                        ORDER BY NombreCliente
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";

                    }
                    if (fechaFiltro == null)
                    {
                        selectQuery = @"SELECT v.VentaId, v.FechaVenta,CONCAT(c.Apellido, ', ', c.Nombres) AS NombreCliente,v.Total 
                        FROM Ventas v join Clientes c on v.ClienteId=c.ClienteId
                        ORDER BY NombreCliente
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    }
                    else
                    {
                        selectQuery = @"SELECT v.VentaId, v.FechaVenta,CONCAT(c.Apellido, ', ', c.Nombres) AS NombreCliente,v.Total 
                        FROM Ventas v join Clientes c on v.ClienteId=c.ClienteId
                        WHERE CAST(c.FechaVenta AS DATE) = @fechaFiltro
                        ORDER BY c.FechaVenta
                        OFFSET @cantidadRegistros ROWS FETCH NEXT @cantidadPorPagina ROWS ONLY";
                    }
                    using (var cmd = new SqlCommand(selectQuery, conn))
                    {
                        if (fechaFiltro != null)
                        {
                            cmd.Parameters.Add("@fechaFiltro", SqlDbType.NVarChar);
                            cmd.Parameters["@fechaFiltro"].Value = fechaFiltro;
                        }
                        if (textoFiltro != null)
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
                                var venta = ConstruirVenta(reader);
                                lista.Add(venta);
                            }
                        }
                    }
                }
                return lista;
            }
            catch (Exception) { throw; }
        }

        private VentaDto ConstruirVenta(SqlDataReader reader)
        {
            return new VentaDto()
            {
                VentaId = reader.GetInt32(0),
                FechaVenta = reader.GetDateTime(1),
                NombreCliente = reader.GetString(2),
                Total = reader.GetDecimal(3)
            };
        }

        public void Guardar(Venta venta)
        {
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string insertQuery = @"INSERT INTO Ventas (FechaVenta, ClienteId, 
                                TransaccionId, Total, EstadoOrden)
                                VALUES (@FechaVenta, @ClienteId, @TransaccionId,  @Total, @EstadoOrden);
                                SELECT SCOPE_IDENTITY()";
                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.Add("@FechaVenta", SqlDbType.DateTime);
                        cmd.Parameters["@FechaVenta"].Value = venta.FechaVenta;

                        cmd.Parameters.Add("@ClienteId", SqlDbType.Int);
                        cmd.Parameters["@ClienteId"].Value = venta.ClienteId;

                        cmd.Parameters.Add("@TransaccionId", SqlDbType.NChar);
                        cmd.Parameters["@TransaccionId"].Value = venta.TransaccionId;

                        cmd.Parameters.Add("@Total", SqlDbType.Decimal);
                        cmd.Parameters["@Total"].Value = (object)venta.Total ?? DBNull.Value;

                        cmd.Parameters.Add("@EstadoOrden", SqlDbType.Int);
                        cmd.Parameters["@EstadoOrden"].Value = venta.EstadoOrden;

                        int id = Convert.ToInt32(cmd.ExecuteScalar());
                        venta.VentaId = id;
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }

        }

        public List<VentaDto> GetVentas(Cliente clienteFiltro)
        {
            throw new NotImplementedException();
        }
    }
}
