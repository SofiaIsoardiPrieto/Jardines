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
    public partial class FrmBuscarPorNombre : Form
    {
        public FrmBuscarPorNombre()
        {
            InitializeComponent();
        }
        private string textoFiltro;
        public string GetTexto()
        {
            return textoFiltro;
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                textoFiltro = BuscarPorTextoBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(BuscarPorTextoBox.Text))
            {
                errorProvider1.SetError(BuscarPorTextoBox, "Debe ingresar al menos una letra");
                validez = false;
            }
            return validez;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
