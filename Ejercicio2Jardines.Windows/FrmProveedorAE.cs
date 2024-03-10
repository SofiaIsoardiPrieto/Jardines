using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmProveedorAE : Form
    {
        private Proveedor proveedor;
        private readonly IServiciosProveedores _servicio;
        private bool esEdicion = false;
        public FrmProveedorAE(IServiciosProveedores servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboPaises(ref paiscomboBox);
            
            if (proveedor!=null)
            {
                nombreproveedortextBox1.Text = proveedor.NombreProveedor;
                direcciontextBox1.Text = proveedor.Direccion;
                CPtextBox2.Text = proveedor.CodigoPostal;
                paiscomboBox.SelectedValue = proveedor.PaisId;
                ciudadcomboBox1.SelectedValue = proveedor.CiudadId;
                esEdicion = true;
            }
        }
        internal Proveedor GetProveedor()
        {
            return proveedor;
        }
        internal void SetProveedor(Proveedor proveedor)
        {
            this.proveedor= proveedor;
        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (proveedor == null)
                {
                    proveedor = new Proveedor();
                }
                proveedor.NombreProveedor = nombreproveedortextBox1.Text;
                proveedor.Direccion = direcciontextBox1.Text;
                proveedor.CodigoPostal = CPtextBox2.Text;
                proveedor.Pais = (Pais)paiscomboBox.SelectedItem;
                proveedor.PaisId = (int)paiscomboBox.SelectedValue;
                proveedor.Ciudad = (Ciudad)ciudadcomboBox1.SelectedItem;
                proveedor.CiudadId = (int)ciudadcomboBox1.SelectedValue;
                try
                {
                    if (!_servicio.Existe(proveedor))
                    {
                        _servicio.Guardar(proveedor);

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
                            proveedor = null;
                            InicializarControles();
                        }
                        else
                        {
                            MessageBox.Show("Registro editado exitosamente", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar el proveedor, ya existe", "Mensaje",
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
            nombreproveedortextBox1.Clear();
            nombreproveedortextBox1.Focus();
            direcciontextBox1.Clear();
            CPtextBox2.Clear();
            paiscomboBox.SelectedIndex = 0;
        }

        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(nombreproveedortextBox1.Text))
            {
                validez = false;
                errorProvider1.SetError(nombreproveedortextBox1,
                    "Debe ingresar el nombre del proveedor");

            }
            if (string.IsNullOrEmpty(direcciontextBox1.Text))
            {
                validez = false;
                errorProvider1.SetError(direcciontextBox1,
                    "Debe ingresar la direccion del proveedor");

            }
            if (string.IsNullOrEmpty(CPtextBox2.Text))
            {
                validez = false;
                errorProvider1.SetError(CPtextBox2,
                    "Debe ingresar el codigo postal del proveedor");

            }
            if (paiscomboBox.SelectedIndex == 0)
            {
                validez = false;
                errorProvider1.SetError(paiscomboBox, "Debe seleccionar un país");
            }
            if (ciudadcomboBox1.SelectedIndex == 0)
            {
                validez = false;
                errorProvider1.SetError(ciudadcomboBox1, "Debe seleccionar una ciudad");
            }

            return validez;
        }

        

        private void paiscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paiscomboBox.SelectedIndex!=0)
            {
                var pais =(Pais) paiscomboBox.SelectedItem;
                CombosHelper.CargarComboCiudades(ref ciudadcomboBox1,pais.PaisId);
            }
            else
            {
                ciudadcomboBox1.DataSource = null;
            }
        }
        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void nuevoPaisbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
