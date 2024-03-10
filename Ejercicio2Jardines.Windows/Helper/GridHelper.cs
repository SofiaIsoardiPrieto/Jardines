using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Cliente;
using Ejercicio2Jardines.Entidades.Dtos.Compra;
using Ejercicio2Jardines.Entidades.Dtos.Producto;
using Ejercicio2Jardines.Entidades.Dtos.Venta;
using Ejercicio2Jardines.Entidades.Entidades;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows.Helper
{
    public static class GridHelper
    { 
        public static void LimpiarGrilla(DataGridView grilla)
        {
            grilla.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView grilla)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(grilla);
            return r;
        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Pais pais:
                    r.Cells[0].Value = pais.NombrePais; 
                    break;
                case CiudadDto ciudadDto:
                    r.Cells[0].Value = ciudadDto.NombrePais;
                    r.Cells[1].Value = ciudadDto.NombreCiudad;
                    break;
                case Categoria categoria:
                    r.Cells[0].Value = categoria.NombreCategoria; 
                    break;
                case ClienteListDto cliente:
                    r.Cells[0].Value = $"{cliente.Apellido}, {cliente.Nombres}";
                    r.Cells[0].Value = cliente.ToString();
                    r.Cells[1].Value = cliente.NombreCiudad; 
                    r.Cells[2].Value = cliente.NombrePais;
                    break;
                case ProveedorDto proveedor:
                    r.Cells[0].Value = proveedor.NombreProveedor;
                    r.Cells[1].Value = proveedor.NombreCiudad;
                    r.Cells[2].Value = proveedor.NombrePais;
                    break;
                case CompraDto compraDto:
                    r.Cells[0].Value = compraDto.CompraId;
                    r.Cells[1].Value = compraDto.FechaCompra;
                    r.Cells[2].Value = compraDto.NombreProveedor;
                    r.Cells[3].Value = compraDto.Total;
                    break;
                case ProductoDto productoDto:
                    r.Cells[0].Value = productoDto.NombreProducto;
                    r.Cells[1].Value = productoDto.Categoria;
                    r.Cells[2].Value = productoDto.PrecioUnitario;
                    r.Cells[3].Value = productoDto.UnidadesEnStock;
                    r.Cells[3].Value = productoDto.Suspendido;
                    break;
                case VentaDto ventaDto:
                    r.Cells[0].Value = ventaDto.VentaId;
                    r.Cells[1].Value = ventaDto.FechaVenta;
                    r.Cells[2].Value = ventaDto.NombreCliente;
                    r.Cells[3].Value = ventaDto.Total;
                    break;
            }
            r.Tag = obj;
        }
        internal static void AgregarFila(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Add(r);
        }
        public static void QuitarFila(DataGridView grilla, DataGridViewRow r)
        {
            grilla.Rows.Remove(r);
        }
    }
}
