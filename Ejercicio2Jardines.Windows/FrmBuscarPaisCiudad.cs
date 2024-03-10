using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos;
using Ejercicio2Jardines.Entidades.Entidades;
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
    public partial class FrmBuscarPaisCiudad : Form
    {
          
        public FrmBuscarPaisCiudad()
        {
            InitializeComponent();
        }
        public Pais paisSeleccionado;
        public CiudadDto ciudadSeleccionada;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
           
            
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult= DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (PaiscomboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaiscomboBox, "Debe seleccionar un país");
            }
            if (CiudadcomboBox1.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CiudadcomboBox1, "Debe seleccionar una ciudad");
            }
            return valido;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void PaiscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaiscomboBox.SelectedIndex != 0)
            {
                paisSeleccionado = (Pais)PaiscomboBox.SelectedItem;
                CombosHelper.CargarComboCiudades(ref CiudadcomboBox1, paisSeleccionado.PaisId);
            }
            else
            {
                paisSeleccionado = null;
                ciudadSeleccionada = null;
                CiudadcomboBox1.DataSource = null;
            }
        }

        private void CiudadcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CiudadcomboBox1.SelectedIndex>0)
            {
                ciudadSeleccionada = (CiudadDto)CiudadcomboBox1.SelectedItem;
            }
            else
            {
                ciudadSeleccionada = null;
            }
        }

        public Pais GetPais()
        {
            return paisSeleccionado;
        }
        public CiudadDto GetCiudad()
        {
            return ciudadSeleccionada;
        }

        private void FrmBuscarPaisCiudad_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboPaises(ref PaiscomboBox);
        }
    }
}
