namespace Ejercicio2Jardines.Windows
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BuscartoolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.porNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizartoolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.imprimirtoolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrartoolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimaPaginabutton4 = new System.Windows.Forms.Button();
            this.siguientebutton = new System.Windows.Forms.Button();
            this.anteriorbutton2 = new System.Windows.Forms.Button();
            this.primeraPaginabutton1 = new System.Windows.Forms.Button();
            this.paginasTotaleslabel5 = new System.Windows.Forms.Label();
            this.paginaActuallabel3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Registroslabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevotoolStripButton,
            this.EditartoolStripButton,
            this.BorrartoolStripButton,
            this.toolStripSeparator1,
            this.BuscartoolStripButton4,
            this.actualizartoolStripButton5,
            this.imprimirtoolStripButton6,
            this.toolStripSeparator2,
            this.cerrartoolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(647, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevotoolStripButton
            // 
            this.NuevotoolStripButton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.nuevo;
            this.NuevotoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevotoolStripButton.Name = "NuevotoolStripButton";
            this.NuevotoolStripButton.Size = new System.Drawing.Size(46, 55);
            this.NuevotoolStripButton.Text = "Nuevo";
            this.NuevotoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevotoolStripButton.Click += new System.EventHandler(this.NuevotoolStripButton_Click);
            // 
            // EditartoolStripButton
            // 
            this.EditartoolStripButton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.editar;
            this.EditartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditartoolStripButton.Name = "EditartoolStripButton";
            this.EditartoolStripButton.Size = new System.Drawing.Size(41, 55);
            this.EditartoolStripButton.Text = "Editar";
            this.EditartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditartoolStripButton.Click += new System.EventHandler(this.EditartoolStripButton_Click);
            // 
            // BorrartoolStripButton
            // 
            this.BorrartoolStripButton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.borrar;
            this.BorrartoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrartoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrartoolStripButton.Name = "BorrartoolStripButton";
            this.BorrartoolStripButton.Size = new System.Drawing.Size(43, 55);
            this.BorrartoolStripButton.Text = "Borrar";
            this.BorrartoolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrartoolStripButton.Click += new System.EventHandler(this.BorrartoolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // BuscartoolStripButton4
            // 
            this.BuscartoolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombreToolStripMenuItem,
            this.porPaisToolStripMenuItem});
            this.BuscartoolStripButton4.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.buscar;
            this.BuscartoolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BuscartoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscartoolStripButton4.Name = "BuscartoolStripButton4";
            this.BuscartoolStripButton4.Size = new System.Drawing.Size(55, 55);
            this.BuscartoolStripButton4.Text = "Buscar";
            this.BuscartoolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // porNombreToolStripMenuItem
            // 
            this.porNombreToolStripMenuItem.Name = "porNombreToolStripMenuItem";
            this.porNombreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porNombreToolStripMenuItem.Text = "Por Nombre";
            this.porNombreToolStripMenuItem.Click += new System.EventHandler(this.porNombreToolStripMenuItem_Click);
            // 
            // porPaisToolStripMenuItem
            // 
            this.porPaisToolStripMenuItem.Name = "porPaisToolStripMenuItem";
            this.porPaisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porPaisToolStripMenuItem.Text = "Por Pais";
            this.porPaisToolStripMenuItem.Click += new System.EventHandler(this.porPaisYCiudadToolStripMenuItem_Click);
            // 
            // actualizartoolStripButton5
            // 
            this.actualizartoolStripButton5.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.actualizar;
            this.actualizartoolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actualizartoolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualizartoolStripButton5.Name = "actualizartoolStripButton5";
            this.actualizartoolStripButton5.Size = new System.Drawing.Size(63, 55);
            this.actualizartoolStripButton5.Text = "Actualizar";
            this.actualizartoolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.actualizartoolStripButton5.Click += new System.EventHandler(this.actualizartoolStripButton5_Click);
            // 
            // imprimirtoolStripButton6
            // 
            this.imprimirtoolStripButton6.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.imprimir;
            this.imprimirtoolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imprimirtoolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirtoolStripButton6.Name = "imprimirtoolStripButton6";
            this.imprimirtoolStripButton6.Size = new System.Drawing.Size(57, 55);
            this.imprimirtoolStripButton6.Text = "Imprimir";
            this.imprimirtoolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // cerrartoolStripButton7
            // 
            this.cerrartoolStripButton7.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.cerrar1;
            this.cerrartoolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrartoolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cerrartoolStripButton7.Name = "cerrartoolStripButton7";
            this.cerrartoolStripButton7.Size = new System.Drawing.Size(47, 55);
            this.cerrartoolStripButton7.Text = "Cerrrar";
            this.cerrartoolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cerrartoolStripButton7.Click += new System.EventHandler(this.cerrartoolStripButton7_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DatosdataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ultimaPaginabutton4);
            this.splitContainer1.Panel2.Controls.Add(this.siguientebutton);
            this.splitContainer1.Panel2.Controls.Add(this.anteriorbutton2);
            this.splitContainer1.Panel2.Controls.Add(this.primeraPaginabutton1);
            this.splitContainer1.Panel2.Controls.Add(this.paginasTotaleslabel5);
            this.splitContainer1.Panel2.Controls.Add(this.paginaActuallabel3);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.Registroslabel);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(647, 226);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 1;
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.AllowUserToResizeColumns = false;
            this.DatosdataGridView.AllowUserToResizeRows = false;
            this.DatosdataGridView.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCliente,
            this.ColCiudad,
            this.ColPais});
            this.DatosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosdataGridView.MultiSelect = false;
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(647, 153);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // ColCliente
            // 
            this.ColCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            // 
            // ColCiudad
            // 
            this.ColCiudad.HeaderText = "Ciudad";
            this.ColCiudad.Name = "ColCiudad";
            this.ColCiudad.ReadOnly = true;
            // 
            // ColPais
            // 
            this.ColPais.HeaderText = "Pais";
            this.ColPais.Name = "ColPais";
            this.ColPais.ReadOnly = true;
            // 
            // ultimaPaginabutton4
            // 
            this.ultimaPaginabutton4.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.fast_forward_36px;
            this.ultimaPaginabutton4.Location = new System.Drawing.Point(333, 19);
            this.ultimaPaginabutton4.Name = "ultimaPaginabutton4";
            this.ultimaPaginabutton4.Size = new System.Drawing.Size(46, 34);
            this.ultimaPaginabutton4.TabIndex = 9;
            this.ultimaPaginabutton4.UseVisualStyleBackColor = true;
            this.ultimaPaginabutton4.Click += new System.EventHandler(this.ultimaPaginabutton4_Click);
            // 
            // siguientebutton
            // 
            this.siguientebutton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.forward_36px;
            this.siguientebutton.Location = new System.Drawing.Point(281, 19);
            this.siguientebutton.Name = "siguientebutton";
            this.siguientebutton.Size = new System.Drawing.Size(46, 34);
            this.siguientebutton.TabIndex = 10;
            this.siguientebutton.UseVisualStyleBackColor = true;
            this.siguientebutton.Click += new System.EventHandler(this.siguientebutton_Click);
            // 
            // anteriorbutton2
            // 
            this.anteriorbutton2.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.back_36px;
            this.anteriorbutton2.Location = new System.Drawing.Point(229, 19);
            this.anteriorbutton2.Name = "anteriorbutton2";
            this.anteriorbutton2.Size = new System.Drawing.Size(46, 34);
            this.anteriorbutton2.TabIndex = 11;
            this.anteriorbutton2.UseVisualStyleBackColor = true;
            this.anteriorbutton2.Click += new System.EventHandler(this.anteriorbutton2_Click);
            // 
            // primeraPaginabutton1
            // 
            this.primeraPaginabutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.rewind_36px;
            this.primeraPaginabutton1.Location = new System.Drawing.Point(177, 19);
            this.primeraPaginabutton1.Name = "primeraPaginabutton1";
            this.primeraPaginabutton1.Size = new System.Drawing.Size(46, 34);
            this.primeraPaginabutton1.TabIndex = 12;
            this.primeraPaginabutton1.UseVisualStyleBackColor = true;
            this.primeraPaginabutton1.Click += new System.EventHandler(this.primeraPaginabutton1_Click);
            // 
            // paginasTotaleslabel5
            // 
            this.paginasTotaleslabel5.AutoSize = true;
            this.paginasTotaleslabel5.Location = new System.Drawing.Point(105, 40);
            this.paginasTotaleslabel5.Name = "paginasTotaleslabel5";
            this.paginasTotaleslabel5.Size = new System.Drawing.Size(13, 13);
            this.paginasTotaleslabel5.TabIndex = 6;
            this.paginasTotaleslabel5.Text = "0";
            // 
            // paginaActuallabel3
            // 
            this.paginaActuallabel3.AutoSize = true;
            this.paginaActuallabel3.Location = new System.Drawing.Point(61, 40);
            this.paginaActuallabel3.Name = "paginaActuallabel3";
            this.paginaActuallabel3.Size = new System.Drawing.Size(13, 13);
            this.paginaActuallabel3.TabIndex = 7;
            this.paginaActuallabel3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "de";
            // 
            // Registroslabel
            // 
            this.Registroslabel.AutoSize = true;
            this.Registroslabel.Location = new System.Drawing.Point(132, 19);
            this.Registroslabel.Name = "Registroslabel";
            this.Registroslabel.Size = new System.Drawing.Size(13, 13);
            this.Registroslabel.TabIndex = 8;
            this.Registroslabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pagina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 284);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevotoolStripButton;
        private System.Windows.Forms.ToolStripButton EditartoolStripButton;
        private System.Windows.Forms.ToolStripButton BorrartoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton actualizartoolStripButton5;
        private System.Windows.Forms.ToolStripButton imprimirtoolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cerrartoolStripButton7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.Button ultimaPaginabutton4;
        private System.Windows.Forms.Button siguientebutton;
        private System.Windows.Forms.Button anteriorbutton2;
        private System.Windows.Forms.Button primeraPaginabutton1;
        private System.Windows.Forms.Label paginasTotaleslabel5;
        private System.Windows.Forms.Label paginaActuallabel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Registroslabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPais;
        private System.Windows.Forms.ToolStripDropDownButton BuscartoolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPaisToolStripMenuItem;
    }
}

