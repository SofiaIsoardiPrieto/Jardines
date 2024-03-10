using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Venta;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmVentaAE : Form
    {
        private Venta venta;
        private readonly IServiciosVentas _servicio;
       
        public FrmVentaAE(IServiciosVentas servicio)
        {
            InitializeComponent();
            _servicio = servicio;           
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboCliente(ref ClientecomboBox1);
        }
        internal Venta GetVenta()
        {
            return venta;
        }
        internal void SetVenta(Venta venta)
        {
            this.venta= venta;
        }
        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (venta == null)
                {
                    venta = new Venta();
                }
                venta.FechaVenta = FechadateTimePicker1.Value;
                venta.ClienteId = (int)ClientecomboBox1.SelectedValue;
                //probando
                Guid newGuid = Guid.NewGuid();
                string guidString = newGuid.ToString();
                int thirdHyphenIndex = guidString.IndexOf('-', guidString.IndexOf('-', guidString.IndexOf('-') + 1) + 1);
                string truncatedGuid = guidString.Substring(0, thirdHyphenIndex);
                venta.TransaccionId = truncatedGuid;
                //probando
                venta.Total = decimal.Parse(TotaltextBox1.Text);
                venta.EstadoOrden = 1;
                
                try
                {
                    if (!_servicio.Existe(venta))
                    {
                        _servicio.Guardar(venta);
                        
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
                            venta = null;
                            InicializarControles();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar el venta, ya existe", "Mensaje",
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
            TotaltextBox1.Clear();
            FechadateTimePicker1.Focus();
            FechadateTimePicker1.ResetText();
            ClientecomboBox1.SelectedIndex = 0;
            
        }

        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            
            if (!decimal.TryParse(TotaltextBox1.Text,out decimal nro))
            {
                validez = false;
                errorProvider1.SetError(TotaltextBox1,
                    "Debe ingresar la total del venta");

            }
           
            if (ClientecomboBox1.SelectedIndex == 0)
            {
                validez = false;
                errorProvider1.SetError(ClientecomboBox1, "Debe seleccionar un cliente");
            }

            return validez;
        }

        
        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
