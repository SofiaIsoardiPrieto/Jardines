namespace Ejercicio2Jardines.Windows
{
    partial class FrmCiudadAE
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
            this.CiudadtextBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PaiscomboBox1 = new System.Windows.Forms.ComboBox();
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton1 = new System.Windows.Forms.Button();
            this.nuevoPaisbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad:";
            // 
            // CiudadtextBox1
            // 
            this.CiudadtextBox1.Location = new System.Drawing.Point(61, 71);
            this.CiudadtextBox1.Name = "CiudadtextBox1";
            this.CiudadtextBox1.Size = new System.Drawing.Size(141, 20);
            this.CiudadtextBox1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pais:";
            // 
            // PaiscomboBox1
            // 
            this.PaiscomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaiscomboBox1.FormattingEnabled = true;
            this.PaiscomboBox1.Location = new System.Drawing.Point(61, 18);
            this.PaiscomboBox1.Name = "PaiscomboBox1";
            this.PaiscomboBox1.Size = new System.Drawing.Size(141, 21);
            this.PaiscomboBox1.TabIndex = 4;
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.aceptar;
            this.Aceptarbutton1.Location = new System.Drawing.Point(29, 109);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(75, 65);
            this.Aceptarbutton1.TabIndex = 2;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton1.UseVisualStyleBackColor = true;
            this.Aceptarbutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // Cancelarbutton1
            // 
            this.Cancelarbutton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.cerrar1;
            this.Cancelarbutton1.Location = new System.Drawing.Point(140, 109);
            this.Cancelarbutton1.Name = "Cancelarbutton1";
            this.Cancelarbutton1.Size = new System.Drawing.Size(75, 65);
            this.Cancelarbutton1.TabIndex = 3;
            this.Cancelarbutton1.Text = "Cancelar";
            this.Cancelarbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton1.UseVisualStyleBackColor = true;
            this.Cancelarbutton1.Click += new System.EventHandler(this.Cancelarbutton1_Click);
            // 
            // nuevoPaisbutton1
            // 
            this.nuevoPaisbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.add_new_36px;
            this.nuevoPaisbutton1.Location = new System.Drawing.Point(215, 10);
            this.nuevoPaisbutton1.Name = "nuevoPaisbutton1";
            this.nuevoPaisbutton1.Size = new System.Drawing.Size(37, 35);
            this.nuevoPaisbutton1.TabIndex = 2;
            this.nuevoPaisbutton1.UseVisualStyleBackColor = true;
            this.nuevoPaisbutton1.Click += new System.EventHandler(this.nuevoPaisbutton1_Click);
            // 
            // FrmCiudadAE
            // 
            this.AcceptButton = this.Aceptarbutton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton1;
            this.ClientSize = new System.Drawing.Size(271, 186);
            this.Controls.Add(this.PaiscomboBox1);
            this.Controls.Add(this.Cancelarbutton1);
            this.Controls.Add(this.nuevoPaisbutton1);
            this.Controls.Add(this.Aceptarbutton1);
            this.Controls.Add(this.CiudadtextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCiudadAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CiudadtextBox1;
        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.Button Cancelarbutton1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox PaiscomboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nuevoPaisbutton1;
    }
}