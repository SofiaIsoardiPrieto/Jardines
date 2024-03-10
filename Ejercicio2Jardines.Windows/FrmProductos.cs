using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Compra;
using Ejercicio2Jardines.Entidades.Dtos.Producto;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios;
using Ejercicio2Jardines.Servicios.Servicios;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmProductos : Form
    {
       
        
        private readonly ServiciosProductos _servicio;
       
        private List<ProductoDto> lista;
        bool filtroON = false;
        string textoFiltro = null;
        //Para paginación 
        int cantidad = 0;
        int paginaActual = 1;
        int registro = 0;
        int paginas = 0;
        int registrosPorPagina = 10;

        public FrmProductos()
        {
            InitializeComponent();
            _servicio= new ServiciosProductos();
            
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                registro = _servicio.GetCantidad();
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        {
            lista = _servicio.GetProductosPorPagina(registrosPorPagina,paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var producto in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.SetearFila(r,producto);
                GridHelper.AgregarFila(DatosdataGridView, r);
            }
            Registroslabel.Text = registro.ToString();
            paginaActuallabel3.Text = paginaActual.ToString();
            paginasTotaleslabel5.Text = paginas.ToString();
            if (paginaActual == paginas)
            {
                siguientebutton.Enabled = false;
                ultimaPaginabutton4.Enabled = false;

            }
            if (paginaActual < paginas)
            {
                siguientebutton.Enabled = true;
                ultimaPaginabutton4.Enabled = true;

            }
            if (paginaActual == 1)
            {
                anteriorbutton2.Enabled = false;
                primeraPaginabutton1.Enabled = false;
            }
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!filtroON)
            {
                FrmBuscarPorNombre frm = new FrmBuscarPorNombre { Text = "Buscar Producto" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    textoFiltro = frm.GetTexto();
                    registro = _servicio.GetCantidad(textoFiltro);
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    paginaActual = 1;
                    lista = _servicio.GetProductosPorPagina(registrosPorPagina, paginaActual, textoFiltro);
                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No hay Productos con esa letra/texto", "Informacion",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    BuscartoolStripButton4.BackColor = Color.CornflowerBlue;
                    filtroON = true;
                    MostrarDatosEnGrilla();
                }

                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Limpie el filtro activo (Actualizar)", "Adevertencia",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cerrartoolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void actualizartoolStripButton5_Click(object sender, EventArgs e)
        {
            textoFiltro = null;
            RecargarGrilla();
            BuscartoolStripButton4.BackColor = Color.Empty;
            filtroON = false;
        }

        private void primeraPaginabutton1_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            anteriorbutton2.Enabled = false;
            primeraPaginabutton1.Enabled = false;
            siguientebutton.Enabled = true;
            ultimaPaginabutton4.Enabled = true;
            MostrarPaginado();
        }

        private void anteriorbutton2_Click(object sender, EventArgs e)
        {
            siguientebutton.Enabled = true;
            ultimaPaginabutton4.Enabled = true;
            paginaActual--;
            if (paginaActual == 1)
            {
                anteriorbutton2.Enabled = false;
                primeraPaginabutton1.Enabled = false;
            }
            MostrarPaginado();
        }

        private void siguientebutton_Click(object sender, EventArgs e)
        {
            anteriorbutton2.Enabled = true;
            primeraPaginabutton1.Enabled = true;
            paginaActual++;
            if (paginaActual == paginas)
            {
                siguientebutton.Enabled = false;
                ultimaPaginabutton4.Enabled = false;

            }
            MostrarPaginado();
        }

        private void ultimaPaginabutton4_Click(object sender, EventArgs e)
        {
            paginaActual = paginas;
            siguientebutton.Enabled = false;
            ultimaPaginabutton4.Enabled = false;
            anteriorbutton2.Enabled = true;
            primeraPaginabutton1.Enabled = true;
            MostrarPaginado();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmProductoAE frm = new FrmProductoAE(_servicio);
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
            MostrarDatosEnGrilla();
        }

        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            ProductoDto productoDto = (ProductoDto)r.Tag;
            ProductoDto productoDtoCopia = (ProductoDto)productoDto.Clone();
            try
            {
                Producto producto = _servicio.GetProductosPorId(productoDto.ProductoId);
                FrmProductoAE frm = new FrmProductoAE(_servicio) { Text = "Editar Producto" };
                frm.SetProducto(producto);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, productoDtoCopia);
                    return;
                }
                producto = frm.GetProducto();
                if (producto != null)
                {
                    GridHelper.SetearFila(r, productoDto);
                }
                else
                {
                    GridHelper.SetearFila(r, productoDtoCopia);
                }
                RecargarGrilla();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, productoDtoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0) return;
            var r = DatosdataGridView.SelectedRows[0];
            ProductoDto producto = (ProductoDto)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                _servicio.Borrar(producto.ProductoId);
                GridHelper.QuitarFila(DatosdataGridView, r);
                registro = _servicio.GetCantidad();
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                Registroslabel.Text = registro.ToString();
                paginasTotaleslabel5.Text = paginas.ToString();
                MessageBox.Show("Producto borrado exitosamente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                RecargarGrilla();
                MostrarDatosEnGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



    
      
      
       
    
}
