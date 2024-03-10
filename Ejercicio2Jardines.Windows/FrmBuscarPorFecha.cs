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
    public partial class FrmBuscarPorFecha : Form
    {
        public FrmBuscarPorFecha()
        {
            InitializeComponent();
        }
        private DateTime fechaFiltro;
        public DateTime GetFecha()
        {
            
            return fechaFiltro;
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
                fechaFiltro = FechadateTimePicker1.Value;
                DialogResult = DialogResult.OK;
        }       
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
