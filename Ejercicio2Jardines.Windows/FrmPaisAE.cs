using Ejercicio2Jardines.Entidades;
using Ejercicio2Jardines.Entidades.Entidades;
using Ejercicio2Jardines.Servicios;
using Ejercicio2Jardines.Servicios.Interfaces;
using Ejercicio2Jardines.Windows.Helper;
using System;
using System.Windows.Forms;

namespace Ejercicio2Jardines.Windows
{
    public partial class FrmPaisAE : Form
    {
        public FrmPaisAE()
        {
            InitializeComponent();
            _servicio=new ServiciosPaises();
        }
        private Pais pais;
        private readonly IServiciosPaises _servicio;
        private bool esEdicion = false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            if (pais != null)
            {
                paistextBox.Text = pais.NombrePais;
                esEdicion = true;
            }
        }
        public Pais GetPais()
        {
            return pais;
        }
        public void SetPais(Pais pais)
        {
            this.pais=pais;
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (pais==null)
                {
                    pais = new Pais();
                }
                pais.NombrePais=paistextBox.Text;
                try
                {
                    if (!_servicio.Existe(pais))
                    {
                        _servicio.Guardar(pais);

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
                            pais = null;
                            InicializarControles();
                        }
                        else
                        {
                            MessageBox.Show("Registro editad exitosamente", "Mensaje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar el pais, ya existe", "Mensaje",
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
            paistextBox.Clear();
            paistextBox.Focus();
        }
        private bool ValidarDatos()
        {
            bool validez=true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(paistextBox.Text))
            {
                validez = false;
                errorProvider1.SetError(paistextBox,
                    "Debe ingresar el nombre de un pais");

            }
            return validez;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
