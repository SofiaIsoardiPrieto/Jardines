namespace Ejercicio2Jardines.Windows
{
    partial class FrmCateogrias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCateogrias));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrartoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BuscartoolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ActualizartoolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ImprimirtoolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CerrartoolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.ColCategorias = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ActualizartoolStripButton5,
            this.ImprimirtoolStripButton6,
            this.toolStripSeparator2,
            this.CerrartoolStripButton7});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(406, 58);
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
            this.BuscartoolStripButton4.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.buscar;
            this.BuscartoolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BuscartoolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BuscartoolStripButton4.Name = "BuscartoolStripButton4";
            this.BuscartoolStripButton4.Size = new System.Drawing.Size(46, 55);
            this.BuscartoolStripButton4.Text = "Buscar";
            this.BuscartoolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ActualizartoolStripButton5
            // 
            this.ActualizartoolStripButton5.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.actualizar;
            this.ActualizartoolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizartoolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizartoolStripButton5.Name = "ActualizartoolStripButton5";
            this.ActualizartoolStripButton5.Size = new System.Drawing.Size(63, 55);
            this.ActualizartoolStripButton5.Text = "Actualizar";
            this.ActualizartoolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ImprimirtoolStripButton6
            // 
            this.ImprimirtoolStripButton6.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.imprimir;
            this.ImprimirtoolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ImprimirtoolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ImprimirtoolStripButton6.Name = "ImprimirtoolStripButton6";
            this.ImprimirtoolStripButton6.Size = new System.Drawing.Size(57, 55);
            this.ImprimirtoolStripButton6.Text = "Imprimir";
            this.ImprimirtoolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // CerrartoolStripButton7
            // 
            this.CerrartoolStripButton7.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.cerrar1;
            this.CerrartoolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CerrartoolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CerrartoolStripButton7.Name = "CerrartoolStripButton7";
            this.CerrartoolStripButton7.Size = new System.Drawing.Size(43, 55);
            this.CerrartoolStripButton7.Text = "Cerrar";
            this.CerrartoolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrartoolStripButton7.Click += new System.EventHandler(this.CerrartoolStripButton7_Click);
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
            this.splitContainer1.Size = new System.Drawing.Size(406, 206);
            this.splitContainer1.SplitterDistance = 132;
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
            this.ColCategorias});
            this.DatosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosdataGridView.MultiSelect = false;
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.Size = new System.Drawing.Size(406, 132);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // ColCategorias
            // 
            this.ColCategorias.HeaderText = "Categorias";
            this.ColCategorias.Name = "ColCategorias";
            this.ColCategorias.ReadOnly = true;
            // 
            // ultimaPaginabutton4
            // 
            this.ultimaPaginabutton4.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.fast_forward_36px;
            this.ultimaPaginabutton4.Location = new System.Drawing.Point(341, 18);
            this.ultimaPaginabutton4.Name = "ultimaPaginabutton4";
            this.ultimaPaginabutton4.Size = new System.Drawing.Size(46, 34);
            this.ultimaPaginabutton4.TabIndex = 9;
            this.ultimaPaginabutton4.UseVisualStyleBackColor = true;
            this.ultimaPaginabutton4.Click += new System.EventHandler(this.ultimaPaginabutton4_Click);
            // 
            // siguientebutton
            // 
            this.siguientebutton.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.forward_36px;
            this.siguientebutton.Location = new System.Drawing.Point(289, 18);
            this.siguientebutton.Name = "siguientebutton";
            this.siguientebutton.Size = new System.Drawing.Size(46, 34);
            this.siguientebutton.TabIndex = 10;
            this.siguientebutton.UseVisualStyleBackColor = true;
            this.siguientebutton.Click += new System.EventHandler(this.siguientebutton_Click);
            // 
            // anteriorbutton2
            // 
            this.anteriorbutton2.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.back_36px;
            this.anteriorbutton2.Location = new System.Drawing.Point(237, 18);
            this.anteriorbutton2.Name = "anteriorbutton2";
            this.anteriorbutton2.Size = new System.Drawing.Size(46, 34);
            this.anteriorbutton2.TabIndex = 11;
            this.anteriorbutton2.UseVisualStyleBackColor = true;
            this.anteriorbutton2.Click += new System.EventHandler(this.anteriorbutton2_Click);
            // 
            // primeraPaginabutton1
            // 
            this.primeraPaginabutton1.Image = global::Ejercicio2Jardines.Windows.Properties.Resources.rewind_36px;
            this.primeraPaginabutton1.Location = new System.Drawing.Point(185, 18);
            this.primeraPaginabutton1.Name = "primeraPaginabutton1";
            this.primeraPaginabutton1.Size = new System.Drawing.Size(46, 34);
            this.primeraPaginabutton1.TabIndex = 12;
            this.primeraPaginabutton1.UseVisualStyleBackColor = true;
            this.primeraPaginabutton1.Click += new System.EventHandler(this.primeraPaginabutton1_Click);
            // 
            // paginasTotaleslabel5
            // 
            this.paginasTotaleslabel5.AutoSize = true;
            this.paginasTotaleslabel5.Location = new System.Drawing.Point(113, 39);
            this.paginasTotaleslabel5.Name = "paginasTotaleslabel5";
            this.paginasTotaleslabel5.Size = new System.Drawing.Size(13, 13);
            this.paginasTotaleslabel5.TabIndex = 6;
            this.paginasTotaleslabel5.Text = "0";
            // 
            // paginaActuallabel3
            // 
            this.paginaActuallabel3.AutoSize = true;
            this.paginaActuallabel3.Location = new System.Drawing.Point(69, 39);
            this.paginaActuallabel3.Name = "paginaActuallabel3";
            this.paginaActuallabel3.Size = new System.Drawing.Size(13, 13);
            this.paginaActuallabel3.TabIndex = 7;
            this.paginaActuallabel3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "de";
            // 
            // Registroslabel
            // 
            this.Registroslabel.AutoSize = true;
            this.Registroslabel.Location = new System.Drawing.Point(140, 18);
            this.Registroslabel.Name = "Registroslabel";
            this.Registroslabel.Size = new System.Drawing.Size(13, 13);
            this.Registroslabel.TabIndex = 8;
            this.Registroslabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pagina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de Registros:";
            // 
            // FrmCateogrias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 264);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCateogrias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCateogrias_Load);
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
        private System.Windows.Forms.ToolStripButton BuscartoolStripButton4;
        private System.Windows.Forms.ToolStripButton ActualizartoolStripButton5;
        private System.Windows.Forms.ToolStripButton ImprimirtoolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CerrartoolStripButton7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategorias;
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
    }
}

