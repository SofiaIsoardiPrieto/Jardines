using Ejercicio2Jardines.Entidades;
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
    public partial class FrmSeleccionarPais : Form
    {
        public FrmSeleccionarPais()
        {
            InitializeComponent();
        }

        private void FrmSeleccionarPais_Load(object sender, EventArgs e)
        {
            CombosHelper.CargarComboPaises(ref paiscomboBox);
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
        private Pais paisSeleccionado;
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                paisSeleccionado=(Pais)paiscomboBox.SelectedItem;
                DialogResult= DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var validez = true;
            errorProvider1.Clear();
            if (paiscomboBox.SelectedIndex==0)
            {
                validez = false;
                errorProvider1.SetError(paiscomboBox,"Debe seleccionar un pais");
            }
            return validez;
        }

        internal Pais GetPais()
        {
            return paisSeleccionado;
        }
    }
}
