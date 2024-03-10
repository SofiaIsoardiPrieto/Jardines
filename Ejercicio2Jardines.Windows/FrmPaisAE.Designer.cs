namespace Ejercicio2Jardines.Windows
{
    partial class FrmPaisAE
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
            this.label1 = new System.Windows.Forms.Label();
            this.paistextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Aceptarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.cerrar1;
            this.Cancelarbutton.Location = new System.Drawing.Point(133, 71);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 66);
            this.Cancelarbutton.TabIndex = 2;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pais:";
            // 
            // paistextBox
            // 
            this.paistextBox.Location = new System.Drawing.Point(70, 27);
            this.paistextBox.MaxLength = 100;
            this.paistextBox.Name = "paistextBox";
            this.paistextBox.Size = new System.Drawing.Size(138, 20);
            this.paistextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.aceptar;
            this.Aceptarbutton.Location = new System.Drawing.Point(30, 71);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(75, 66);
            this.Aceptarbutton.TabIndex = 1;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // FrmPaisAE
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(229, 149);
            this.Controls.Add(this.paistextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.MinimumSize = new System.Drawing.Size(245, 188);
            this.Name = "FrmPaisAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paistextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}