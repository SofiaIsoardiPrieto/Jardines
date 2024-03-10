using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Dtos.Producto;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmProductoAE : Form
    {
        private Producto producto;
        private readonly IServiciosProductos _servicio;
        private bool esEdicion = false;
        public FrmProductoAE(IServiciosProductos servicio)
        {
            InitializeComponent();
            _servicio = servicio;           
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboCategoria(ref CategoriacomboBox);
            CombosHelper.CargarComboProveedores(ref ProveedorcomboBox1);
            
            if (producto!=null)
            {
                ProductoclientetextBox1.Text = producto.NombreProducto;
                NombreLatintextBox1.Text = producto.NombreLatin;
                PreciotextBox1.Text = producto.PrecioUnitario.ToString();
                StocknumericUpDown1.Value = producto.UnidadesEnStock;
                StockMinnumericUpDown2.Value = producto.UnidadesEnPedido;
                CategoriacomboBox.SelectedValue = producto.CategoriaId;
                ProveedorcomboBox1.SelectedValue = producto.ProveedorId;
                esEdicion = true;
            }
        }
        internal Producto GetProducto()
        {
            return producto;
        }
        internal void SetProducto(Producto producto)
        {
            this.producto= producto;
        }

        private void Aceptarbutton1_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto == null)
                {
                    producto = new Producto();
                }
                producto.NombreProducto = ProductoclientetextBox1.Text;
                producto.NombreLatin = NombreLatintextBox1.Text;
                producto.PrecioUnitario =decimal.Parse( PreciotextBox1.Text);
                producto.UnidadesEnStock = int.Parse(StocknumericUpDown1.Text);
                producto.UnidadesEnPedido = int.Parse(StockMinnumericUpDown2.Text);
                producto.CategoriaId = (int)CategoriacomboBox.SelectedValue;
                producto.ProveedorId = (int)ProveedorcomboBox1.SelectedValue;
                try
                {
                    if (!_servicio.Existe(producto))
                    {
                        _servicio.Guardar(producto);

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
                            producto = null;
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
                        MessageBox.Show("Error al ingresar el producto, ya existe", "Mensaje",
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
            ProductoclientetextBox1.Clear();
            ProductoclientetextBox1.Focus();
            NombreLatintextBox1.Clear();
            PreciotextBox1.Clear();
            StocknumericUpDown1.Value=1;
            StockMinnumericUpDown2.Value=1;
            CategoriacomboBox.SelectedIndex = 0;
            ProveedorcomboBox1.SelectedIndex = 0;
            SuspendidocheckBox1.Checked = false;
        }

        private bool ValidarDatos()
        {
            bool validez = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ProductoclientetextBox1.Text))
            {
                validez = false;
                errorProvider1.SetError(NombreLatintextBox1,
                    "Debe ingresar el nombre del producto");

            }
            if (!decimal.TryParse(PreciotextBox1.Text,out decimal nro))
            {
                validez = false;
                errorProvider1.SetError(PreciotextBox1,
                    "Debe ingresar la direccion del producto");

            }
            if (CategoriacomboBox.SelectedIndex == 0)
            {
                validez = false;
                errorProvider1.SetError(CategoriacomboBox, "Debe seleccionar una categoria");
            }
            if (ProveedorcomboBox1.SelectedIndex == 0)
            {
                validez = false;
                errorProvider1.SetError(ProveedorcomboBox1, "Debe seleccionar un proveedor");
            }

            return validez;
        }

        
        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CategoriacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProveedorcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevaCiudadbutton1_Click(object sender, EventArgs e)
        {

        }
    }
}
