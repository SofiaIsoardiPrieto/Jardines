using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Servicios;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmCiudades : Form
    {
        private readonly ServiciosCiudades _servicio;
        private List<CiudadDto> lista;
        bool filtroON = false;
        string textoFiltro = null;
        //Para paginación 
        int paginaActual = 1;
        int registro = 0;
        int paginas = 0;
        int registrosPorPagina = 10;

        public FrmCiudades()
        {
            InitializeComponent();
            _servicio = new ServiciosCiudades();
        }
        private void frmCiudades_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
            
        } 
        private void RecargarGrilla()
        {
            try
            {
                registro = _servicio.GetCantidad(null);
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                MostrarPaginado();
            }
            catch (Exception) { throw; }
        }
        private void MostrarPaginado()
        { 
            lista = _servicio.GetCiudadesPorPagina(registrosPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }
        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(DatosdataGridView);
            foreach (var ciudad in lista)
            {
                DataGridViewRow r = GridHelper.ConstruirFila(DatosdataGridView);
                GridHelper.SetearFila(r, ciudad);
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
            FrmCiudadAE frm = new FrmCiudadAE(_servicio);
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
            Ciudad ciudad = (Ciudad)r.Tag;
            Ciudad ciudadCopia = (Ciudad)ciudad.Clone();
            try
            {
                FrmCiudadAE frm = new FrmCiudadAE(_servicio) { Text = "Editar País" };
                frm.SetCiudad(ciudad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    GridHelper.SetearFila(r, ciudadCopia);
                    return;
                }
                ciudad = frm.GetCiudad();
                if (ciudad != null)
                {
                    GridHelper.SetearFila(r, ciudad);
                }
                else
                {
                    GridHelper.SetearFila(r, ciudadCopia);
                }
            }
            catch (Exception ex)
            {
                GridHelper.SetearFila(r, ciudadCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void BorrartoolStripButton_Click(object sender, EventArgs e)
        {
            if (DatosdataGridView.SelectedRows.Count == 0) return;
            var r = DatosdataGridView.SelectedRows[0];
            Ciudad ciudad = (Ciudad)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                _servicio.Borrar(ciudad.CiudadId);
                GridHelper.QuitarFila(DatosdataGridView, r);
                registro = _servicio.GetCantidad(null);
                paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                Registroslabel.Text = registro.ToString();
                paginasTotaleslabel5.Text = paginas.ToString();
                MessageBox.Show("Ciudad borrado exitosamente", "Mensaje",
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
        private void BuscartoolStripButton4_Click(object sender, EventArgs e)
        {
            if (!filtroON)
            {
                FrmSeleccionarPais frm = new FrmSeleccionarPais();
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                try
                {
                    var pais = frm.GetPais();
                    lista = _servicio.GetCiudades(pais.PaisId);
                    if (lista.Count == 0)
                    {
                        MessageBox.Show("No hay Ciudades con el Pais seleccionado", "Informacion",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    registro = _servicio.GetCantidad(pais.PaisId);
                    paginas = FormHelper.CalcularPaginas(registro, registrosPorPagina);
                    paginaActual = 1;
                    BuscartoolStripButton4.BackColor = Color.CornflowerBlue;
                    filtroON = true;
                    MostrarDatosEnGrilla();
                    
                }
                catch (Exception) { throw; }
            }
            else
            {
                MessageBox.Show("Limpie el filtro activo (Actualizar)", "Adevertencia",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ActualizartoolStripButton5_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
            filtroON = false;
            BuscartoolStripButton4.BackColor = Color.White;
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

        private void CerrartoolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
