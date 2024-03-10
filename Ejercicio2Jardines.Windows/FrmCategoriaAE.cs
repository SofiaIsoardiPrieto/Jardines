using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Servicios.Servicios;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmCategoriaAE : Form
    {
        private Categoria categoria;
        private readonly IServiciosCategorias _servicio;
        private bool esEdicion = false;
        public FrmCategoriaAE()
        {
            InitializeComponent();
            _servicio = new ServiciosCategorias();
           
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (categoria != null)
            {
                CategoriatextBox.Text = categoria.NombreCategoria;
                esEdicion = true;
            }
        }
        public Categoria GetCategoria()
        {
            return categoria;
        }
        public void SetCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }
        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            if (ValidadDatos())
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.NombreCategoria = CategoriatextBox.Text;


                try
                {
                    if (!_servicio.Existe(categoria))
                    {
                        _servicio.Guardar(categoria);

                        if (!esEdicion)
                        {
                            MessageBox.Show("Registro ingresado exitosamente", "Mensaje",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult dr = MessageBox.Show("¿Desea agregar otro registro?",
                                 "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2);
                            if (dr == DialogResult.No)
                            {
                                DialogResult = DialogResult.OK;
                                return;
                            }
                            categoria = null;
                            InicializarControles();
                        }
                        else
                        {
                            MessageBox.Show("Registro editada exitosamente", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar la categoria, ya existe", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InicializarControles();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void InicializarControles()
        {
            CategoriatextBox.Clear();
            CategoriatextBox.Focus();
        }
        private bool ValidadDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(CategoriatextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(CategoriatextBox,
                    "Debe ingresar el nombre de un pais");

            }
            return validez;
        }

        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
