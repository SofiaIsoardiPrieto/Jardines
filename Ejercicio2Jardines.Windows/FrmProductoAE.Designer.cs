namespace Ejercicio2Jardines.Windows
{
    partial class FrmProductoAE
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
            this.ProductoclientetextBox1 = new System.Windows.Forms.TextBox();
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombreLatintextBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.ProveedorcomboBox1 = new System.Windows.Forms.ComboBox();
            this.PreciotextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nuevoPaisbutton1 = new System.Windows.Forms.Button();
            this.NuevaCiudadbutton1 = new System.Windows.Forms.Button();
            this.StocknumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.StockMinnumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendidocheckBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StocknumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockMinnumericUpDown2)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // ProductoclientetextBox1
            // 
            this.ProductoclientetextBox1.Location = new System.Drawing.Point(100, 41);
            this.ProductoclientetextBox1.MaxLength = 50;
            this.ProductoclientetextBox1.Name = "ProductoclientetextBox1";
            this.ProductoclientetextBox1.Size = new System.Drawing.Size(147, 20);
            this.ProductoclientetextBox1.TabIndex = 0;
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.aceptar;
            this.Aceptarbutton1.Location = new System.Drawing.Point(125, 180);
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
            this.Cancelarbutton2.Location = new System.Drawing.Point(388, 175);
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
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Precio Vta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre Latin:";
            // 
            // NombreLatintextBox1
            // 
            this.NombreLatintextBox1.Location = new System.Drawing.Point(100, 67);
            this.NombreLatintextBox1.MaxLength = 50;
            this.NombreLatintextBox1.Name = "NombreLatintextBox1";
            this.NombreLatintextBox1.Size = new System.Drawing.Size(147, 20);
            this.NombreLatintextBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stock:";
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Location = new System.Drawing.Point(331, 52);
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            this.CategoriacomboBox.Size = new System.Drawing.Size(133, 21);
            this.CategoriacomboBox.TabIndex = 8;
            this.CategoriacomboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriacomboBox_SelectedIndexChanged);
            // 
            // ProveedorcomboBox1
            // 
            this.ProveedorcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedorcomboBox1.FormattingEnabled = true;
            this.ProveedorcomboBox1.Location = new System.Drawing.Point(331, 103);
            this.ProveedorcomboBox1.Name = "ProveedorcomboBox1";
            this.ProveedorcomboBox1.Size = new System.Drawing.Size(133, 21);
            this.ProveedorcomboBox1.TabIndex = 8;
            this.ProveedorcomboBox1.SelectedIndexChanged += new System.EventHandler(this.ProveedorcomboBox1_SelectedIndexChanged);
            // 
            // PreciotextBox1
            // 
            this.PreciotextBox1.Location = new System.Drawing.Point(100, 98);
            this.PreciotextBox1.MaxLength = 100;
            this.PreciotextBox1.Name = "PreciotextBox1";
            this.PreciotextBox1.Size = new System.Drawing.Size(100, 20);
            this.PreciotextBox1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stock minimo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Proveedor:";
            // 
            // nuevoPaisbutton1
            // 
            this.nuevoPaisbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.add_new_36px;
            this.nuevoPaisbutton1.Location = new System.Drawing.Point(470, 44);
            this.nuevoPaisbutton1.Name = "nuevoPaisbutton1";
            this.nuevoPaisbutton1.Size = new System.Drawing.Size(36, 35);
            this.nuevoPaisbutton1.TabIndex = 9;
            this.nuevoPaisbutton1.UseVisualStyleBackColor = true;
            // 
            // NuevaCiudadbutton1
            // 
            this.NuevaCiudadbutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.add_new_36px;
            this.NuevaCiudadbutton1.Location = new System.Drawing.Point(470, 95);
            this.NuevaCiudadbutton1.Name = "NuevaCiudadbutton1";
            this.NuevaCiudadbutton1.Size = new System.Drawing.Size(36, 35);
            this.NuevaCiudadbutton1.TabIndex = 9;
            this.NuevaCiudadbutton1.UseVisualStyleBackColor = true;
            this.NuevaCiudadbutton1.Click += new System.EventHandler(this.NuevaCiudadbutton1_Click);
            // 
            // StocknumericUpDown1
            // 
            this.StocknumericUpDown1.Location = new System.Drawing.Point(100, 124);
            this.StocknumericUpDown1.Name = "StocknumericUpDown1";
            this.StocknumericUpDown1.ReadOnly = true;
            this.StocknumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.StocknumericUpDown1.TabIndex = 10;
            // 
            // StockMinnumericUpDown2
            // 
            this.StockMinnumericUpDown2.Location = new System.Drawing.Point(100, 154);
            this.StockMinnumericUpDown2.Name = "StockMinnumericUpDown2";
            this.StockMinnumericUpDown2.ReadOnly = true;
            this.StockMinnumericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.StockMinnumericUpDown2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Suspendido:";
            // 
            // SuspendidocheckBox1
            // 
            this.SuspendidocheckBox1.AutoSize = true;
            this.SuspendidocheckBox1.Location = new System.Drawing.Point(315, 145);
            this.SuspendidocheckBox1.Name = "SuspendidocheckBox1";
            this.SuspendidocheckBox1.Size = new System.Drawing.Size(15, 14);
            this.SuspendidocheckBox1.TabIndex = 11;
            this.SuspendidocheckBox1.UseVisualStyleBackColor = true;
            // 
            // FrmProductoAE
            // 
            this.AcceptButton = this.Aceptarbutton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton2;
            this.ClientSize = new System.Drawing.Size(528, 270);
            this.Controls.Add(this.SuspendidocheckBox1);
            this.Controls.Add(this.StockMinnumericUpDown2);
            this.Controls.Add(this.StocknumericUpDown1);
            this.Controls.Add(this.NuevaCiudadbutton1);
            this.Controls.Add(this.nuevoPaisbutton1);
            this.Controls.Add(this.ProveedorcomboBox1);
            this.Controls.Add(this.CategoriacomboBox);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Aceptarbutton1);
            this.Controls.Add(this.PreciotextBox1);
            this.Controls.Add(this.NombreLatintextBox1);
            this.Controls.Add(this.ProductoclientetextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmProductoAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StocknumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockMinnumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button Cancelarbutton2;
        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.TextBox ProductoclientetextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreLatintextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProveedorcomboBox1;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.TextBox PreciotextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button NuevaCiudadbutton1;
        private System.Windows.Forms.Button nuevoPaisbutton1;
        private System.Windows.Forms.NumericUpDown StockMinnumericUpDown2;
        private System.Windows.Forms.NumericUpDown StocknumericUpDown1;
        private System.Windows.Forms.CheckBox SuspendidocheckBox1;
        private System.Windows.Forms.Label label9;
    }
}