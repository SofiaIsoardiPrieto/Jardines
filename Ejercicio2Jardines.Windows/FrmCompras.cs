using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Compra;
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
    public partial class FrmCompras : Form
    {
       
        private readonly ServiciosCompras _servicio;
       
        private List<CompraDto> lista;
        bool filtroON = false;
        DateTime fechaFiltro =DateTime.Now;
        //Para paginación 

        private int paginaActual = 1;
        private int registro = 0;
        private int paginas = 0;
        private int registrosPorPagina = 10;

        public FrmCompras()
        {
            InitializeComponent();
            _servicio = new ServiciosCompras();
            
        }
        private void FrmCompras_Load(object sender, EventArgs e)
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
            lista = _servicio.GetComprasPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var Compra in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.SetearFila(r,Compra);
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
        private void actualizartoolStripButton5_Click(object sender, EventArgs e)
        {
            fechaFiltro = DateTime.Now;
            RecargarGrilla();
            BuscartoolStripButton4.BackColor = Color.Empty;
            filtroON = false;
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
        private void primeraPaginabutton1_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            anteriorbutton2.Enabled = false;
            primeraPaginabutton1.Enabled = false;
            siguientebutton.Enabled = true;
            ultimaPaginabutton4.Enabled = true;
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
        private void cerrartoolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmCompraAE frm = new FrmCompraAE(_servicio);
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
            MostrarDatosEnGrilla();
        }

        private void fechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!filtroON)
            {
                FrmBuscarPorFecha frm = new FrmBuscarPorFecha();
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    fechaFiltro = frm.GetFecha();
                    registro = _servicio.GetCantidad(fechaFiltro);
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    paginaActual = 1;
                    lista = _servicio.GetComprasPorPagina(registrosPorPagina, paginaActual, fechaFiltro);
                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No hay compras realizadas en esa fecha", "Informacion",
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
        private string textoFiltro = null;
        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!filtroON)
            {
                FrmBuscarPorNombre frm = new FrmBuscarPorNombre { Text = "Buscar Clientes" };
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    textoFiltro = frm.GetTexto();
                    registro = _servicio.GetCantidad(null,textoFiltro);
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    paginaActual = 1;
                    lista = _servicio.GetComprasPorPagina(registrosPorPagina, paginaActual,null, textoFiltro);
                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No hay Clientes con esa letra/texto", "Informacion",
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
    }
}
