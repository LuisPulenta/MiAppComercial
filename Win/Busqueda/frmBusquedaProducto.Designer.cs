
namespace Win.Busqueda
{
    partial class frmBusquedaProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaProducto));
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.iDIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iVABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUnidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.codigoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.codigoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.descripcionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.descripcionToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.productoTableAdapter = new Win.DSMiAppComercialTableAdapters.ProductoTableAdapter();
            this.categoriaTableAdapter = new Win.DSMiAppComercialTableAdapters.CategoriaTableAdapter();
            this.iVATableAdapter = new Win.DSMiAppComercialTableAdapters.IVATableAdapter();
            this.unidadTableAdapter = new Win.DSMiAppComercialTableAdapters.UnidadTableAdapter();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitarFiltros = new System.Windows.Forms.Button();
            this.rbtIgual = new System.Windows.Forms.RadioButton();
            this.rbtTermina = new System.Windows.Forms.RadioButton();
            this.rbtEmpiece = new System.Windows.Forms.RadioButton();
            this.rbtContenga = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.iDCategoriaDataGridViewTextBoxColumn,
            this.iDIVADataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.iDUnidadDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.productoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Location = new System.Drawing.Point(1, 170);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1300, 503);
            this.dgvDatos.TabIndex = 15;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDCategoriaDataGridViewTextBoxColumn
            // 
            this.iDCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IDCategoria";
            this.iDCategoriaDataGridViewTextBoxColumn.DataSource = this.categoriaBindingSource;
            this.iDCategoriaDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDCategoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.iDCategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCategoriaDataGridViewTextBoxColumn.Name = "iDCategoriaDataGridViewTextBoxColumn";
            this.iDCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCategoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCategoriaDataGridViewTextBoxColumn.ValueMember = "IDCategoria";
            this.iDCategoriaDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "Categoria";
            this.categoriaBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // dSMiAppComercial
            // 
            this.dSMiAppComercial.DataSetName = "DSMiAppComercial";
            this.dSMiAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDIVADataGridViewTextBoxColumn
            // 
            this.iDIVADataGridViewTextBoxColumn.DataPropertyName = "IDIVA";
            this.iDIVADataGridViewTextBoxColumn.DataSource = this.iVABindingSource;
            this.iDIVADataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDIVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iDIVADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDIVADataGridViewTextBoxColumn.Name = "iDIVADataGridViewTextBoxColumn";
            this.iDIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDIVADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDIVADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDIVADataGridViewTextBoxColumn.ValueMember = "IDIVA";
            this.iDIVADataGridViewTextBoxColumn.Width = 125;
            // 
            // iVABindingSource
            // 
            this.iVABindingSource.DataMember = "IVA";
            this.iVABindingSource.DataSource = this.dSMiAppComercial;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDUnidadDataGridViewTextBoxColumn
            // 
            this.iDUnidadDataGridViewTextBoxColumn.DataPropertyName = "IDUnidad";
            this.iDUnidadDataGridViewTextBoxColumn.DataSource = this.unidadBindingSource;
            this.iDUnidadDataGridViewTextBoxColumn.DisplayMember = "Descripcion";
            this.iDUnidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
            this.iDUnidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDUnidadDataGridViewTextBoxColumn.Name = "iDUnidadDataGridViewTextBoxColumn";
            this.iDUnidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUnidadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDUnidadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDUnidadDataGridViewTextBoxColumn.ValueMember = "IDUnidad";
            this.iDUnidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // unidadBindingSource
            // 
            this.unidadBindingSource.DataMember = "Unidad";
            this.unidadBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "Medida";
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.medidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codigoToolStripLabel,
            this.codigoToolStripTextBox,
            this.descripcionToolStripLabel,
            this.descripcionToolStripTextBox,
            this.tsbBuscar});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1321, 55);
            this.fillBy1ToolStrip.TabIndex = 16;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // codigoToolStripLabel
            // 
            this.codigoToolStripLabel.Name = "codigoToolStripLabel";
            this.codigoToolStripLabel.Size = new System.Drawing.Size(61, 52);
            this.codigoToolStripLabel.Text = "Codigo:";
            // 
            // codigoToolStripTextBox
            // 
            this.codigoToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codigoToolStripTextBox.Name = "codigoToolStripTextBox";
            this.codigoToolStripTextBox.Size = new System.Drawing.Size(100, 55);
            // 
            // descripcionToolStripLabel
            // 
            this.descripcionToolStripLabel.Name = "descripcionToolStripLabel";
            this.descripcionToolStripLabel.Size = new System.Drawing.Size(90, 52);
            this.descripcionToolStripLabel.Text = "Descripcion:";
            // 
            // descripcionToolStripTextBox
            // 
            this.descripcionToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descripcionToolStripTextBox.Name = "descripcionToolStripTextBox";
            this.descripcionToolStripTextBox.Size = new System.Drawing.Size(100, 55);
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject("tsbBuscar.Image")));
            this.tsbBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(52, 52);
            this.tsbBuscar.Text = "FillBy1";
            this.tsbBuscar.ToolTipText = "Aplica los criterios de búsqueda seleccionados";
            this.tsbBuscar.Click += new System.EventHandler(this.tsbBuscar_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // iVATableAdapter
            // 
            this.iVATableAdapter.ClearBeforeFill = true;
            // 
            // unidadTableAdapter
            // 
            this.unidadTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1149, 81);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 32;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1210, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(736, 71);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 60);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(618, 71);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 60);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitarFiltros);
            this.groupBox1.Controls.Add(this.rbtIgual);
            this.groupBox1.Controls.Add(this.rbtTermina);
            this.groupBox1.Controls.Add(this.rbtEmpiece);
            this.groupBox1.Controls.Add(this.rbtContenga);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 56);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo criterio";
            // 
            // btnQuitarFiltros
            // 
            this.btnQuitarFiltros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuitarFiltros.Location = new System.Drawing.Point(466, 12);
            this.btnQuitarFiltros.Name = "btnQuitarFiltros";
            this.btnQuitarFiltros.Size = new System.Drawing.Size(128, 38);
            this.btnQuitarFiltros.TabIndex = 8;
            this.btnQuitarFiltros.Text = "&Quitar Filtros";
            this.btnQuitarFiltros.UseVisualStyleBackColor = true;
            this.btnQuitarFiltros.Click += new System.EventHandler(this.btnQuitarFiltros_Click);
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.Location = new System.Drawing.Point(381, 22);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(79, 21);
            this.rbtIgual.TabIndex = 3;
            this.rbtIgual.Text = "Igual a…";
            this.rbtIgual.UseVisualStyleBackColor = true;
            // 
            // rbtTermina
            // 
            this.rbtTermina.AutoSize = true;
            this.rbtTermina.Location = new System.Drawing.Point(255, 22);
            this.rbtTermina.Name = "rbtTermina";
            this.rbtTermina.Size = new System.Drawing.Size(109, 21);
            this.rbtTermina.TabIndex = 2;
            this.rbtTermina.Text = "Termina en…";
            this.rbtTermina.UseVisualStyleBackColor = true;
            // 
            // rbtEmpiece
            // 
            this.rbtEmpiece.AutoSize = true;
            this.rbtEmpiece.Location = new System.Drawing.Point(133, 22);
            this.rbtEmpiece.Name = "rbtEmpiece";
            this.rbtEmpiece.Size = new System.Drawing.Size(116, 21);
            this.rbtEmpiece.TabIndex = 1;
            this.rbtEmpiece.Text = "Empiece por…";
            this.rbtEmpiece.UseVisualStyleBackColor = true;
            // 
            // rbtContenga
            // 
            this.rbtContenga.AutoSize = true;
            this.rbtContenga.Checked = true;
            this.rbtContenga.Location = new System.Drawing.Point(20, 22);
            this.rbtContenga.Name = "rbtContenga";
            this.rbtContenga.Size = new System.Drawing.Size(98, 21);
            this.rbtContenga.TabIndex = 0;
            this.rbtContenga.TabStop = true;
            this.rbtContenga.Text = "Contenga…";
            this.rbtContenga.UseVisualStyleBackColor = true;
            // 
            // frmBusquedaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1321, 693);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBusquedaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Búsqueda de Producto---";
            this.Load += new System.EventHandler(this.frmBusquedaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSMiAppComercialTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DSMiAppComercialTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.BindingSource iVABindingSource;
        private DSMiAppComercialTableAdapters.IVATableAdapter iVATableAdapter;
        private System.Windows.Forms.BindingSource unidadBindingSource;
        private DSMiAppComercialTableAdapters.UnidadTableAdapter unidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDUnidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel codigoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox codigoToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel descripcionToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox descripcionToolStripTextBox;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQuitarFiltros;
        private System.Windows.Forms.RadioButton rbtIgual;
        private System.Windows.Forms.RadioButton rbtTermina;
        private System.Windows.Forms.RadioButton rbtEmpiece;
        private System.Windows.Forms.RadioButton rbtContenga;
    }
}