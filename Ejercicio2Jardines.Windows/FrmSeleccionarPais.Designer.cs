namespace Ejercicio2Jardines.Windows
{
    partial class FrmSeleccionarPais
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
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.paiscomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.cerrar1;
            this.Cancelarbutton.Location = new System.Drawing.Point(183, 69);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 66);
            this.Cancelarbutton.TabIndex = 4;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.aceptar;
            this.Aceptarbutton.Location = new System.Drawing.Point(15, 69);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 66);
            this.Aceptarbutton.TabIndex = 3;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // paiscomboBox
            // 
            this.paiscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paiscomboBox.FormattingEnabled = true;
            this.paiscomboBox.Location = new System.Drawing.Point(50, 22);
            this.paiscomboBox.Name = "paiscomboBox";
            this.paiscomboBox.Size = new System.Drawing.Size(208, 21);
            this.paiscomboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "País:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmSeleccionarPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paiscomboBox);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Name = "FrmSeleccionarPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeleccionarPais";
            this.Load += new System.EventHandler(this.FrmSeleccionarPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.ComboBox paiscomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}