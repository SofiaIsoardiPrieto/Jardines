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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Paisesbutton_Click(object sender, EventArgs e)
        {
            FrmPaises frm = new FrmPaises();
            frm.ShowDialog();
        }

        private void Categoriasbutton2_Click(object sender, EventArgs e)
        {
            FrmCateogrias frm = new FrmCateogrias();
            frm.ShowDialog();
        }

        private void Ciudadesbutton3_Click(object sender, EventArgs e)
        {
            FrmCiudades frm=new FrmCiudades();  
            frm.ShowDialog();
        }

        private void Cerrarbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesbutton5_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        private void Proveedoresbutton4_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.ShowDialog();
        }

        private void Ventasbutton1_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.ShowDialog();
        }

        private void Productosbutton6_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();
        }

        private void Comprasbutton1_Click(object sender, EventArgs e)
        {
            FrmCompras frm = new FrmCompras();
            frm.ShowDialog();
        }
    }
}
