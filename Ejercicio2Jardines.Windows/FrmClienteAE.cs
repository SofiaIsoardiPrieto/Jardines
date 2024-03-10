using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Cliente;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmClienteAE : Form
    {
        private Cliente cliente;
        private readonly IServiciosClientes _servicio;
        private bool esEdicion = false;
        public FrmClienteAE(IServiciosClientes servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboPaises(ref paiscomboBox);
            
            if (cliente!=null)
            {
                nombreclientetextBox1.Text = cliente.Nombre;
                apellidotextBox1.Text = cliente.Apellido;
                direcciontextBox1.Text = cliente.Direccion;
                CPtextBox2.Text = cliente.CodigoPostal;
                emailtextBox1.Text = cliente.Email;
                paiscomboBox.SelectedValue = cliente.PaisId;
                ciudadcomboBox1.SelectedValue = cliente.CiudadId;
                esEdicion = true;
            }
        }
        internal Cliente GetCliente()
        {
            return cliente;
        }
        internal void SetCliente(Cliente cliente)
        {
            this.cliente= cliente;
        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cliente == null)
                {
                    cliente = new Cliente();
                }
                cliente.Nombre = nombreclientetextBox1.Text;
                cliente.Apellido = apellidotextBox1.Text;
                cliente.Direccion = direcciontextBox1.Text;
                cliente.CodigoPostal = CPtextBox2.Text;
                cliente.Email = emailtextBox1.Text;
                cliente.Pais = (Pais)paiscomboBox.SelectedItem;
                cliente.PaisId = (int)paiscomboBox.SelectedValue;
                cliente.Ciudad = (Ciudad)ciudadcomboBox1.SelectedItem;
                cliente.CiudadId = (int)ciudadcomboBox1.SelectedValue;
                try
                {
                    if (!_servicio.Existe(cliente))
                    {
                        _servicio.Guardar(cliente);

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
                            cliente = null;
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
                        MessageBox.Show("Error al ingresar el cliente, ya existe", "Mensaje",
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
            nombreclientetextBox1.Clear();
            nombreclientetextBox1.Focus();
            apellidotextBox1.Clear();
            direcciontextBox1.Clear();
            CPtextBox2.Clear();
            emailtextBox1.Clear();
            paiscomboBox.SelectedIndex = 0;
        }

        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(nombreclientetextBox1.Text))
            {
                validez = false;
                errorProvider1.SetError(nombreclientetextBox1,
                    "Debe ingresar el nombre del cliente");

            }
            if (string.IsNullOrEmpty(apellidotextBox1.Text))
            {
                validez = false;
                errorProvider1.SetError(apellidotextBox1,
                    "Debe ingresar el apellido del cliente");

            }
            if (string.IsNullOrEmpty(direcciontextBox1.Text))
            {
                validez = false;
                errorProvider1.SetError(direcciontextBox1,
                    "Debe ingresar la direccion del cliente");

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

        private void NuevaCiudadbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
