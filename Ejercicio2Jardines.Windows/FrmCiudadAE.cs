using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios;
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
    public partial class FrmCiudadAE : Form
    {
        private Ciudad ciudad;
        private readonly IServiciosCiudades _servicio;
        private bool esEdicion=false;
        public FrmCiudadAE(IServiciosCiudades servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboPaises(ref PaiscomboBox1);
            if (ciudad!=null)
            {
                CiudadtextBox1.Text = ciudad.NombreCiudad;
                PaiscomboBox1.SelectedValue = ciudad.PaisId;
                esEdicion=true;
            }
        }     
        public Ciudad GetCiudad()
        {
            return ciudad;
        }
        public void SetCiudad(Ciudad ciudad)
        {
            this.ciudad = ciudad;
        }
        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (ciudad==null)
                {
                    ciudad = new Ciudad();
                }
                ciudad.NombreCiudad = CiudadtextBox1.Text;
                ciudad.Pais=(Pais)PaiscomboBox1.SelectedItem;
                ciudad.PaisId = (int)PaiscomboBox1.SelectedValue;
                try
                {    
                    if (!_servicio.Existe(ciudad))
                    {
                        _servicio.Guardar(ciudad);

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
                            ciudad = null;
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
                        MessageBox.Show("Error al ingresar la ciudad, ya existe", "Mensaje",
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
            PaiscomboBox1.SelectedIndex = 0;
            CiudadtextBox1.Clear();
            PaiscomboBox1.Focus();
        }
        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (PaiscomboBox1.SelectedIndex==0)
            {
                validez = false;
                errorProvider1.SetError(PaiscomboBox1, "Seleccione un pais");
            }
            if (string.IsNullOrEmpty(CiudadtextBox1.Text))
            {
                validez = false;
                errorProvider1.SetError(CiudadtextBox1,
                    "Debe ingresar el nombre de un pais");

            }
            return validez;
        }
        private void nuevoPaisbutton1_Click(object sender, EventArgs e)
        {
            var _serviciosPaises = new ServiciosPaises();
            FrmPaisAE frm = new FrmPaisAE() { Text="Agregar pais"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            try
            {
                var pais = frm.GetPais();
                if (!_serviciosPaises.Existe(pais))
                {
                    _serviciosPaises.Guardar(pais);
                    MessageBox.Show("Pais ingreso exitosamente", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Error al ingresar el pais, ya existe", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CombosHelper.CargarComboPaises(ref PaiscomboBox1);
        }
        private void Cancelarbutton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
