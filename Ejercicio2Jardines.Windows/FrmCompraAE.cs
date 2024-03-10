using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Dtos.Proveedor;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Servicios.Servicios;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmCompraAE : Form
    {
        private Compra compra;
        private readonly IServiciosCompras _servicio;
        private bool esEdicion = false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboProveedores (ref ProveedorcomboBox1);

            
        }
        public FrmCompraAE(IServiciosCompras servicios)
        {
            InitializeComponent();
            _servicio=servicios;
        }
        public void SetCompra(Compra compra)
        {
            this.compra = compra;
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    if (compra == null)
                    {
                        compra = new Compra();
                    }
                    compra.FechaCompra = FechadateTimePicker1.Value;
                    compra.Proveedor = (ProveedorComboDto)ProveedorcomboBox1.SelectedItem;
                    compra.ProveedorId = (int)ProveedorcomboBox1.SelectedValue;
                    compra.Total = decimal.Parse(TotaltextBox.Text);
                    try
                    {
                        if (!_servicio.Existe(compra))
                        {
                            _servicio.Guardar(compra);

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
                            compra = null;
                            InicializarControles();

                        }
                        else
                        {
                            MessageBox.Show("Error al ingresar la compra, ya existe", "Mensaje",
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
            catch (Exception)
            {

                throw;
            }
        }
        private void InicializarControles()
        {
            TotaltextBox.Clear();
            TotaltextBox.Focus();
            FechadateTimePicker1.ResetText();
        }
        private bool ValidarDatos()
        {
            bool validez=true;
            errorProvider1.Clear();
            if (ProveedorcomboBox1.SelectedIndex==0)
            {
                validez = false;
                errorProvider1.SetError(ProveedorcomboBox1,
                    "Debe seleccionar el nombre de un proveedor");

            }
            if (!decimal.TryParse(TotaltextBox.Text,out decimal Nro))
            {
                validez = false;
                errorProvider1.SetError(TotaltextBox,
                    "Debe ingresar un numero válido");
            }
         
            return validez;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
