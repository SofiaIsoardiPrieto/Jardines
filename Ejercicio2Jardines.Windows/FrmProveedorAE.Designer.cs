namespace Ejercicio2Jardines.Windows
{
    partial class FrmProveedorAE
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.nombreproveedortextBox1 = new System.Windows.Forms.TextBox();
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.paiscomboBox = new System.Windows.Forms.ComboBox();
            this.ciudadcomboBox1 = new System.Windows.Forms.ComboBox();
            this.direcciontextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CPtextBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nuevoPaisbutton1 = new System.Windows.Forms.Button();
            this.NuevaCiudadbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // nombreproveedortextBox1
            // 
            this.nombreproveedortextBox1.Location = new System.Drawing.Point(88, 41);
            this.nombreproveedortextBox1.MaxLength = 50;
            this.nombreproveedortextBox1.Name = "nombreproveedortextBox1";
            this.nombreproveedortextBox1.Size = new System.Drawing.Size(100, 20);
            this.nombreproveedortextBox1.TabIndex = 0;
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.aceptar;
            this.Aceptarbutton1.Location = new System.Drawing.Point(71, 185);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(75, 63);
            this.Aceptarbutton1.TabIndex = 5;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton1.UseVisualStyleBackColor = true;
            this.Aceptarbutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // Cancelarbutton2
            // 
            this.Cancelarbutton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton2.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.cerrar1;
            this.Cancelarbutton2.Location = new System.Drawing.Point(277, 185);
            this.Cancelarbutton2.Name = "Cancelarbutton2";
            this.Cancelarbutton2.Size = new System.Drawing.Size(75, 63);
            this.Cancelarbutton2.TabIndex = 6;
            this.Cancelarbutton2.Text = "Cancelar";
            this.Cancelarbutton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton2.UseVisualStyleBackColor = true;
            this.Cancelarbutton2.Click += new System.EventHandler(this.Cancelarbutton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ciudad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Proveedor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pais:";
            // 
            // paiscomboBox
            // 
            this.paiscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paiscomboBox.FormattingEnabled = true;
            this.paiscomboBox.Location = new System.Drawing.Point(249, 36);
            this.paiscomboBox.Name = "paiscomboBox";
            this.paiscomboBox.Size = new System.Drawing.Size(133, 21);
            this.paiscomboBox.TabIndex = 8;
            this.paiscomboBox.SelectedIndexChanged += new System.EventHandler(this.paiscomboBox_SelectedIndexChanged);
            // 
            // ciudadcomboBox1
            // 
            this.ciudadcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadcomboBox1.FormattingEnabled = true;
            this.ciudadcomboBox1.Location = new System.Drawing.Point(249, 87);
            this.ciudadcomboBox1.Name = "ciudadcomboBox1";
            this.ciudadcomboBox1.Size = new System.Drawing.Size(133, 21);
            this.ciudadcomboBox1.TabIndex = 8;
            // 
            // direcciontextBox1
            // 
            this.direcciontextBox1.Location = new System.Drawing.Point(88, 90);
            this.direcciontextBox1.MaxLength = 100;
            this.direcciontextBox1.Name = "direcciontextBox1";
            this.direcciontextBox1.Size = new System.Drawing.Size(100, 20);
            this.direcciontextBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dirección:";
            // 
            // CPtextBox2
            // 
            this.CPtextBox2.Location = new System.Drawing.Point(88, 131);
            this.CPtextBox2.MaxLength = 10;
            this.CPtextBox2.Name = "CPtextBox2";
            this.CPtextBox2.Size = new System.Drawing.Size(100, 20);
            this.CPtextBox2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "C.P.:";
            // 
            // nuevoPaisbutton1
            // 
            this.nuevoPaisbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.add_new_36px;
            this.nuevoPaisbutton1.Location = new System.Drawing.Point(388, 28);
            this.nuevoPaisbutton1.Name = "nuevoPaisbutton1";
            this.nuevoPaisbutton1.Size = new System.Drawing.Size(36, 35);
            this.nuevoPaisbutton1.TabIndex = 9;
            this.nuevoPaisbutton1.UseVisualStyleBackColor = true;
            this.nuevoPaisbutton1.Click += new System.EventHandler(this.nuevoPaisbutton1_Click);
            // 
            // NuevaCiudadbutton1
            // 
            this.NuevaCiudadbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.add_new_36px;
            this.NuevaCiudadbutton1.Location = new System.Drawing.Point(388, 79);
            this.NuevaCiudadbutton1.Name = "NuevaCiudadbutton1";
            this.NuevaCiudadbutton1.Size = new System.Drawing.Size(36, 35);
            this.NuevaCiudadbutton1.TabIndex = 9;
            this.NuevaCiudadbutton1.UseVisualStyleBackColor = true;
            // 
            // FrmProveedorAE
            // 
            this.AcceptButton = this.Aceptarbutton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton2;
            this.ClientSize = new System.Drawing.Size(459, 276);
            this.Controls.Add(this.NuevaCiudadbutton1);
            this.Controls.Add(this.nuevoPaisbutton1);
            this.Controls.Add(this.ciudadcomboBox1);
            this.Controls.Add(this.paiscomboBox);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Aceptarbutton1);
            this.Controls.Add(this.CPtextBox2);
            this.Controls.Add(this.direcciontextBox1);
            this.Controls.Add(this.nombreproveedortextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmProveedorAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AE";
            this.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Cancelarbutton2;
        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.TextBox nombreproveedortextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ciudadcomboBox1;
        private System.Windows.Forms.ComboBox paiscomboBox;
        private System.Windows.Forms.TextBox CPtextBox2;
        private System.Windows.Forms.TextBox direcciontextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NuevaCiudadbutton1;
        private System.Windows.Forms.Button nuevoPaisbutton1;
    }
}