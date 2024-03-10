namespace Ejercicio2Jardines.Windows
{
    partial class FrmCategoriaAE
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
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriatextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.aceptar;
            this.Aceptarbutton1.Location = new System.Drawing.Point(12, 73);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(75, 64);
            this.Aceptarbutton1.TabIndex = 2;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton1.UseVisualStyleBackColor = true;
            this.Aceptarbutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // Cancelarbutton2
            // 
            this.Cancelarbutton2.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.cerrar1;
            this.Cancelarbutton2.Location = new System.Drawing.Point(125, 73);
            this.Cancelarbutton2.Name = "Cancelarbutton2";
            this.Cancelarbutton2.Size = new System.Drawing.Size(75, 64);
            this.Cancelarbutton2.TabIndex = 3;
            this.Cancelarbutton2.Text = "Cancelar";
            this.Cancelarbutton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton2.UseVisualStyleBackColor = true;
            this.Cancelarbutton2.Click += new System.EventHandler(this.Cancelarbutton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria:";
            // 
            // CategoriatextBox
            // 
            this.CategoriatextBox.Location = new System.Drawing.Point(82, 30);
            this.CategoriatextBox.Name = "CategoriatextBox";
            this.CategoriatextBox.Size = new System.Drawing.Size(118, 20);
            this.CategoriatextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmCategoriaAE
            // 
            this.AcceptButton = this.Aceptarbutton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton2;
            this.ClientSize = new System.Drawing.Size(229, 149);
            this.Controls.Add(this.CategoriatextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Aceptarbutton1);
            this.Name = "FrmCategoriaAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.Button Cancelarbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoriatextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}