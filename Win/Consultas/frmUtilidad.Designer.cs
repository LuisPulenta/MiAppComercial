
namespace Win.Consultas
{
    partial class frmUtilidad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUtilidad));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.label2 = new System.Windows.Forms.Label();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.utilidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.utilidadTableAdapter = new Win.DSMiAppComercialTableAdapters.UtilidadTableAdapter();
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            this.categoriaTableAdapter = new Win.DSMiAppComercialTableAdapters.CategoriaTableAdapter();
            this.chkElegir = new System.Windows.Forms.CheckBox();
            this.btnSeleccionarTodo = new System.Windows.Forms.Button();
            this.btnDeseleccionarTodo = new System.Windows.Forms.Button();
            this.nuPorcPrecio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nuPorcCosto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nuPorcUtilidad = new System.Windows.Forms.NumericUpDown();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacénDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoríaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuevoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuevoCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuevaUtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPorcPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPorcCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPorcUtilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataSource = this.categoriaBindingSource;
            this.categoriaComboBox.DisplayMember = "Descripcion";
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(102, 35);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(321, 24);
            this.categoriaComboBox.TabIndex = 38;
            this.categoriaComboBox.ValueMember = "IDCategoria";
            this.categoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaComboBox_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Categoría:";
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataSource = this.almacenBindingSource;
            this.almacenComboBox.DisplayMember = "Descripcion";
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(102, 6);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(263, 24);
            this.almacenComboBox.TabIndex = 36;
            this.almacenComboBox.ValueMember = "IDAlmacen";
            this.almacenComboBox.SelectedIndexChanged += new System.EventHandler(this.almacenComboBox_SelectedIndexChanged);
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "Almacen";
            this.almacenBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Almacén:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir,
            this.IDAlmacen,
            this.IDCategoria,
            this.almacénDataGridViewTextBoxColumn,
            this.categoríaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn,
            this.Precio,
            this.Costo,
            this.Utilidad,
            this.NuevoPrecio,
            this.NuevoCosto,
            this.NuevaUtil});
            this.dgvDatos.DataSource = this.utilidadBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDatos.Location = new System.Drawing.Point(12, 160);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1297, 537);
            this.dgvDatos.TabIndex = 93;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // utilidadBindingSource
            // 
            this.utilidadBindingSource.DataMember = "Utilidad";
            this.utilidadBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1265, 112);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 92;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1221, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // utilidadTableAdapter
            // 
            this.utilidadTableAdapter.ClearBeforeFill = true;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // chkElegir
            // 
            this.chkElegir.AutoSize = true;
            this.chkElegir.Location = new System.Drawing.Point(11, 126);
            this.chkElegir.Name = "chkElegir";
            this.chkElegir.Size = new System.Drawing.Size(66, 21);
            this.chkElegir.TabIndex = 94;
            this.chkElegir.Text = "Elegir";
            this.chkElegir.UseVisualStyleBackColor = true;
            this.chkElegir.CheckedChanged += new System.EventHandler(this.chkElegir_CheckedChanged);
            // 
            // btnSeleccionarTodo
            // 
            this.btnSeleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarTodo.Image")));
            this.btnSeleccionarTodo.Location = new System.Drawing.Point(83, 120);
            this.btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            this.btnSeleccionarTodo.Size = new System.Drawing.Size(32, 32);
            this.btnSeleccionarTodo.TabIndex = 95;
            this.btnSeleccionarTodo.UseVisualStyleBackColor = true;
            this.btnSeleccionarTodo.Click += new System.EventHandler(this.btnSeleccionarTodo_Click);
            // 
            // btnDeseleccionarTodo
            // 
            this.btnDeseleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnDeseleccionarTodo.Image")));
            this.btnDeseleccionarTodo.Location = new System.Drawing.Point(121, 120);
            this.btnDeseleccionarTodo.Name = "btnDeseleccionarTodo";
            this.btnDeseleccionarTodo.Size = new System.Drawing.Size(32, 32);
            this.btnDeseleccionarTodo.TabIndex = 96;
            this.btnDeseleccionarTodo.UseVisualStyleBackColor = true;
            this.btnDeseleccionarTodo.Click += new System.EventHandler(this.btnDeseleccionarTodo_Click);
            // 
            // nuPorcPrecio
            // 
            this.nuPorcPrecio.Location = new System.Drawing.Point(769, 28);
            this.nuPorcPrecio.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuPorcPrecio.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nuPorcPrecio.Name = "nuPorcPrecio";
            this.nuPorcPrecio.Size = new System.Drawing.Size(68, 22);
            this.nuPorcPrecio.TabIndex = 97;
            this.nuPorcPrecio.ValueChanged += new System.EventHandler(this.nuPorcPrecio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "% Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(699, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "% Costo:";
            // 
            // nuPorcCosto
            // 
            this.nuPorcCosto.Location = new System.Drawing.Point(769, 56);
            this.nuPorcCosto.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuPorcCosto.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nuPorcCosto.Name = "nuPorcCosto";
            this.nuPorcCosto.Size = new System.Drawing.Size(68, 22);
            this.nuPorcCosto.TabIndex = 99;
            this.nuPorcCosto.ValueChanged += new System.EventHandler(this.nuPorcCosto_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(688, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 102;
            this.label5.Text = "% Utilidad:";
            // 
            // nuPorcUtilidad
            // 
            this.nuPorcUtilidad.Location = new System.Drawing.Point(769, 84);
            this.nuPorcUtilidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuPorcUtilidad.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            this.nuPorcUtilidad.Name = "nuPorcUtilidad";
            this.nuPorcUtilidad.Size = new System.Drawing.Size(68, 22);
            this.nuPorcUtilidad.TabIndex = 101;
            this.nuPorcUtilidad.ValueChanged += new System.EventHandler(this.nuPorcUtilidad_ValueChanged);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.MinimumWidth = 6;
            this.Elegir.Name = "Elegir";
            this.Elegir.ReadOnly = true;
            this.Elegir.Visible = false;
            this.Elegir.Width = 125;
            // 
            // IDAlmacen
            // 
            this.IDAlmacen.DataPropertyName = "IDAlmacen";
            this.IDAlmacen.HeaderText = "IDAlmacen";
            this.IDAlmacen.MinimumWidth = 6;
            this.IDAlmacen.Name = "IDAlmacen";
            this.IDAlmacen.ReadOnly = true;
            this.IDAlmacen.Visible = false;
            this.IDAlmacen.Width = 125;
            // 
            // IDCategoria
            // 
            this.IDCategoria.DataPropertyName = "IDCategoria";
            this.IDCategoria.HeaderText = "IDCategoria";
            this.IDCategoria.MinimumWidth = 6;
            this.IDCategoria.Name = "IDCategoria";
            this.IDCategoria.ReadOnly = true;
            this.IDCategoria.Visible = false;
            this.IDCategoria.Width = 125;
            // 
            // almacénDataGridViewTextBoxColumn
            // 
            this.almacénDataGridViewTextBoxColumn.DataPropertyName = "Almacén";
            this.almacénDataGridViewTextBoxColumn.HeaderText = "Almacén";
            this.almacénDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.almacénDataGridViewTextBoxColumn.Name = "almacénDataGridViewTextBoxColumn";
            this.almacénDataGridViewTextBoxColumn.ReadOnly = true;
            this.almacénDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoríaDataGridViewTextBoxColumn
            // 
            this.categoríaDataGridViewTextBoxColumn.DataPropertyName = "Categoría";
            this.categoríaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.categoríaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoríaDataGridViewTextBoxColumn.Name = "categoríaDataGridViewTextBoxColumn";
            this.categoríaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoríaDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Cód";
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
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Un";
            this.unidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadDataGridViewTextBoxColumn.Width = 125;
            // 
            // medidaDataGridViewTextBoxColumn
            // 
            this.medidaDataGridViewTextBoxColumn.DataPropertyName = "Medida";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.medidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Med";
            this.medidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.medidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Costo
            // 
            this.Costo.DataPropertyName = "UltimoCosto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Costo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 125;
            // 
            // Utilidad
            // 
            this.Utilidad.DataPropertyName = "Utilidad";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.Utilidad.DefaultCellStyle = dataGridViewCellStyle7;
            this.Utilidad.HeaderText = "Utilidad";
            this.Utilidad.MinimumWidth = 6;
            this.Utilidad.Name = "Utilidad";
            this.Utilidad.ReadOnly = true;
            this.Utilidad.Width = 125;
            // 
            // NuevoPrecio
            // 
            this.NuevoPrecio.DataPropertyName = "txtNuevoPrecio";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            this.NuevoPrecio.DefaultCellStyle = dataGridViewCellStyle8;
            this.NuevoPrecio.HeaderText = "Nuevo Precio";
            this.NuevoPrecio.MinimumWidth = 6;
            this.NuevoPrecio.Name = "NuevoPrecio";
            this.NuevoPrecio.ReadOnly = true;
            this.NuevoPrecio.Width = 125;
            // 
            // NuevoCosto
            // 
            this.NuevoCosto.DataPropertyName = "txtNuevoCosto";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.NuevoCosto.DefaultCellStyle = dataGridViewCellStyle9;
            this.NuevoCosto.HeaderText = "Nuevo Costo";
            this.NuevoCosto.MinimumWidth = 6;
            this.NuevoCosto.Name = "NuevoCosto";
            this.NuevoCosto.ReadOnly = true;
            this.NuevoCosto.Width = 125;
            // 
            // NuevaUtil
            // 
            this.NuevaUtil.DataPropertyName = "txtNuevaUtil";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.NuevaUtil.DefaultCellStyle = dataGridViewCellStyle10;
            this.NuevaUtil.HeaderText = "Nueva Util.";
            this.NuevaUtil.MinimumWidth = 6;
            this.NuevaUtil.Name = "NuevaUtil";
            this.NuevaUtil.ReadOnly = true;
            this.NuevaUtil.Width = 125;
            // 
            // frmUtilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1321, 709);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nuPorcUtilidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nuPorcCosto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuPorcPrecio);
            this.Controls.Add(this.btnDeseleccionarTodo);
            this.Controls.Add(this.btnSeleccionarTodo);
            this.Controls.Add(this.chkElegir);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUtilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Utilidad---";
            this.Load += new System.EventHandler(this.frmUtilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPorcPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPorcCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPorcUtilidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource utilidadBindingSource;
        private DSMiAppComercial dSMiAppComercial;
        private DSMiAppComercialTableAdapters.UtilidadTableAdapter utilidadTableAdapter;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DSMiAppComercialTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.CheckBox chkElegir;
        private System.Windows.Forms.Button btnSeleccionarTodo;
        private System.Windows.Forms.Button btnDeseleccionarTodo;
        private System.Windows.Forms.NumericUpDown nuPorcPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuPorcCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuPorcUtilidad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacénDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoríaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuevoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuevoCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuevaUtil;
    }
}