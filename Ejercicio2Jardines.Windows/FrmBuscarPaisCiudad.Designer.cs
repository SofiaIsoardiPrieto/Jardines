namespace Ejercicio2Jardines.Windows
{
    partial class FrmBuscarPaisCiudad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.PaiscomboBox = new System.Windows.Forms.ComboBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CiudadcomboBox1 = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "País:";
            // 
            // PaiscomboBox
            // 
            this.PaiscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaiscomboBox.FormattingEnabled = true;
            this.PaiscomboBox.Location = new System.Drawing.Point(64, 15);
            this.PaiscomboBox.Name = "PaiscomboBox";
            this.PaiscomboBox.Size = new System.Drawing.Size(208, 21);
            this.PaiscomboBox.TabIndex = 9;
            this.PaiscomboBox.SelectedIndexChanged += new System.EventHandler(this.PaiscomboBox_SelectedIndexChanged);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.cerrar1;
            this.Cancelarbutton.Location = new System.Drawing.Point(197, 108);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 66);
            this.Cancelarbutton.TabIndex = 8;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.aceptar;
            this.Aceptarbutton.Location = new System.Drawing.Point(29, 108);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 66);
            this.Aceptarbutton.TabIndex = 7;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ciudad:";
            // 
            // CiudadcomboBox1
            // 
            this.CiudadcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadcomboBox1.FormattingEnabled = true;
            this.CiudadcomboBox1.Location = new System.Drawing.Point(64, 50);
            this.CiudadcomboBox1.Name = "CiudadcomboBox1";
            this.CiudadcomboBox1.Size = new System.Drawing.Size(208, 21);
            this.CiudadcomboBox1.TabIndex = 9;
            this.CiudadcomboBox1.SelectedIndexChanged += new System.EventHandler(this.CiudadcomboBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarPaisCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 186);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CiudadcomboBox1);
            this.Controls.Add(this.PaiscomboBox);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Name = "FrmBuscarPaisCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarPaisCiudad";
            this.Load += new System.EventHandler(this.FrmBuscarPaisCiudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PaiscomboBox;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CiudadcomboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}