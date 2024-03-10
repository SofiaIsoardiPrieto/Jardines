using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Servicios;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmCateogrias : Form
    {

        private ServiciosCategorias _servicios;
        private List<Categoria> lista;
        bool filtroON = false;
        string textoFiltro = null;
        //Para paginación 
        int paginaActual = 1;
        int registro = 0;
        int paginas = 0;
        int registrosPorPagina = 12;

        public FrmCateogrias()
        {
            InitializeComponent();
            _servicios = new ServiciosCategorias();
        }
        private void FrmCateogrias_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }
        private void RecargarGrilla()
        {
            try
            {
                registro = _servicios.GetCantidad();
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception) { throw; }

        }
        private void MostrarPaginado()
        {
            lista = _servicios.GetCategoriaPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var categoria in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.SetearFila(r, categoria);
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
        private void NuevotoolStripButton_Click(object sender, EventArgs e)
        {
            FrmCategoriaAE frm = new FrmCategoriaAE();
            DialogResult dr= frm.ShowDialog(this);
            RecargarGrilla();
        }
        private void EditartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DatosdataGridView.SelectedRows[0];
            Categoria categoria = (Categoria)r.Tag;
            Categoria categoriaCopia = (Categoria)categoria.Clone();
            try
            {
                FrmCategoriaAE frm = new FrmCategoriaAE() { Text = "Editar País" };
                frm.SetCategoria(categoria);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, categoriaCopia);
                    return;
                }
                categoria = frm.GetCategoria();
                if (categoria != null)
                {
                    GridHelper.SetearFila(r, categoria);
                }
                else
                {
                    GridHelper.SetearFila(r, categoriaCopia);
                }
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, categoriaCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0) return;
            var r = DatosdataGridView.SelectedRows[0];
            Categoria categoria = (Categoria)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                _servicios.Borrar(categoria.CategoriaId);
                GridHelper.QuitarFila(DatosdataGridView, r);
                registro = _servicios.GetCantidad();
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                Registroslabel.Text = registro.ToString();
                paginasTotaleslabel5.Text = paginas.ToString();
                MessageBox.Show("Categoria borrada exitosamente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            MostrarPaginado(); ;
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
        private void CerrartoolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }   
}
