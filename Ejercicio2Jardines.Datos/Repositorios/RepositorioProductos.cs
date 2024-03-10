using Dapper;
using Ejercicio2Jardines.Datos.Interfaces;
using Ejercicio2Jardines.Entidades.Dtos.Producto;
using Ejercicio2Jardines.Entidades.Entidades;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Ejercicio2Jardines.Datos.Repositorios
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly string cadenaConexion;
        public RepositorioProductos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Producto producto)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string addQuery = @"INSERT INTO Productos(NombreProducto, NombreLatin, ProveedorId,
                            CategoriaId, PrecioUnitario, UnidadesEnStock, UnidadesEnPedido,
                            NivelDeReposicion, Suspendido , Imagen)
                            VALUES (@NombreProducto, @NombreLatin,
                            @ProveedorId, @CategoriaId, @PrecioUnitario,
                            @UnidadesEnStock,@UnidadesEnPedido,@NivelDeReposicion,
                            @Suspendido, @Imagen)
                            SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(addQuery, producto);
                producto.ProductoId = id;
            }
        }
        public void Editar(Producto producto)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string updateQuery = @"UPDATE Productos SET NombreProducto=@NombreProducto,
                                NombreLatin=@NombreLatin, CategoriaId=@CategoriaId, 
                                ProveedorId=@ProveedorId, PrecioUnitario=@PrecioUnitario, 
                                UnidadesEnStock=@UnidadesEnStock, NivelDeReposicion=@NivelDeReposicion,                                 
                                Suspendido=@Suspendido, Imagen=@Imagen
                                WHERE ProductoId=@ProductoId";
                conn.Execute(updateQuery, producto);
            }
        }
        public void Borrar(int productoId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string deleteQuery = "DELETE FROM Productos WHERE productoId=@productoId";
                conn.Execute(deleteQuery, new { productoId });
            }
        }
        public bool Existe(Producto producto)
        {
            var cantidad = 0;

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery;
                if (producto.ProductoId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Productos 
                        WHERE NombreProducto=@NombreProducto";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, producto);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Productos 
                        WHERE NombreProducto=@NombreProducto and productoId!=@productoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, producto);
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
                    selectQuery = "SELECT COUNT(*) FROM Productos";
                    cantidad = conn.ExecuteScalar<int>(selectQuery);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Productos
                                       WHERE NombreProducto LIKE @textoFiltro + '%'";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, new { textoFiltro });
                }
            }
            return cantidad;
        }

        public Producto GetProductosPorId(int productoId)
        {
            Producto producto = null;

            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery = @"SELECT ProductoId, NombreProducto, NombreLatin, ProveedorId,
                     CategoriaId, PrecioUnitario, UnidadesEnStock, UnidadesEnPedido ,
                        NivelDeReposicion, Suspendido, Imagen
                        FROM Productos WHERE productoId=@productoId";
                producto = conn.QuerySingle<Producto>(selectQuery, new { productoId });
            }
            return producto;
        }
        public List<ProductoDto> GetProductosPorPagina(int cantidadPorPagina, int paginaActual, string textoFiltro = null)
        {
            List<ProductoDto> lista = new List<ProductoDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {

                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = @"SELECT p.ProductoId,p.NombreProducto,c.NombreCategoria,
                            p.PrecioUnitario,p.UnidadesEnStock,p.Suspendido
                            FROM Productos p join Categorias c on p.CategoriaId=c.CategoriaId
                            join Proveedores pro on p.ProveedorId=pro.ProveedorId
                            ORDER BY p.NombreProducto";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<ProductoDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina }).ToList();
                }
                else
                {
                    selectQuery = @"SELECT p.ProductoId,p.NombreProducto,c.NombreCategoria,
                                p.PrecioUnitario,p.UnidadesEnStock,p.Suspendido
                                FROM Productos p join Categorias c on p.CategoriaId=c.CategoriaId
                                join Proveedores pro on p.ProveedorId=pro.ProveedorId
                                WHERE p.NombreProducto like @textoFiltro + '%'
                                ORDER BY p.NombreProducto";
                    var cantidadRegistros = cantidadPorPagina * (paginaActual - 1);
                    lista = conn.Query<ProductoDto>(selectQuery, new { cantidadRegistros, cantidadPorPagina, textoFiltro }).ToList();
                }
            }
            return lista;
        }
    }
}
