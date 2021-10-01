
namespace Win.Consultas
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categoriasCheckBox = new System.Windows.Forms.CheckBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.label2 = new System.Windows.Forms.Label();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.almacenesCheckBox = new System.Windows.Forms.CheckBox();
            this.productosCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productoLabel = new System.Windows.Forms.Label();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.totalUltimoCostoTextBox = new System.Windows.Forms.TextBox();
            this.totalCostoPromedioTextBox = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.almacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoríaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPromedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUltimoCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCostoPromedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            this.categoriaTableAdapter = new Win.DSMiAppComercialTableAdapters.CategoriaTableAdapter();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.stockTableAdapter = new Win.DSMiAppComercialTableAdapters.StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriasCheckBox
            // 
            this.categoriasCheckBox.AutoSize = true;
            this.categoriasCheckBox.Checked = true;
            this.categoriasCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.categoriasCheckBox.Location = new System.Drawing.Point(108, 44);
            this.categoriasCheckBox.Name = "categoriasCheckBox";
            this.categoriasCheckBox.Size = new System.Drawing.Size(70, 21);
            this.categoriasCheckBox.TabIndex = 33;
            this.categoriasCheckBox.Text = "Todos";
            this.categoriasCheckBox.UseVisualStyleBackColor = true;
            this.categoriasCheckBox.CheckedChanged += new System.EventHandler(this.categoriasCheckBox_CheckedChanged);
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataSource = this.categoriaBindingSource;
            this.categoriaComboBox.DisplayMember = "Descripcion";
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(184, 42);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(321, 24);
            this.categoriaComboBox.TabIndex = 32;
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
            this.label2.Location = new System.Drawing.Point(24, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Categoría:";
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataSource = this.almacenBindingSource;
            this.almacenComboBox.DisplayMember = "Descripcion";
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(184, 13);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(263, 24);
            this.almacenComboBox.TabIndex = 30;
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
            this.label3.Location = new System.Drawing.Point(36, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Almacén:";
            // 
            // almacenesCheckBox
            // 
            this.almacenesCheckBox.AutoSize = true;
            this.almacenesCheckBox.Checked = true;
            this.almacenesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.almacenesCheckBox.Location = new System.Drawing.Point(108, 15);
            this.almacenesCheckBox.Name = "almacenesCheckBox";
            this.almacenesCheckBox.Size = new System.Drawing.Size(70, 21);
            this.almacenesCheckBox.TabIndex = 34;
            this.almacenesCheckBox.Text = "Todos";
            this.almacenesCheckBox.UseVisualStyleBackColor = true;
            this.almacenesCheckBox.CheckedChanged += new System.EventHandler(this.almacenesCheckBox_CheckedChanged);
            // 
            // productosCheckBox
            // 
            this.productosCheckBox.AutoSize = true;
            this.productosCheckBox.Checked = true;
            this.productosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.productosCheckBox.Location = new System.Drawing.Point(108, 72);
            this.productosCheckBox.Name = "productosCheckBox";
            this.productosCheckBox.Size = new System.Drawing.Size(70, 21);
            this.productosCheckBox.TabIndex = 36;
            this.productosCheckBox.Text = "Todos";
            this.productosCheckBox.UseVisualStyleBackColor = true;
            this.productosCheckBox.CheckedChanged += new System.EventHandler(this.productosCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Producto:";
            // 
            // productoLabel
            // 
            this.productoLabel.AutoSize = true;
            this.productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLabel.ForeColor = System.Drawing.Color.Blue;
            this.productoLabel.Location = new System.Drawing.Point(425, 74);
            this.productoLabel.Name = "productoLabel";
            this.productoLabel.Size = new System.Drawing.Size(190, 17);
            this.productoLabel.TabIndex = 60;
            this.productoLabel.Text = "Descripción del Producto";
            // 
            // productoTextBox
            // 
            this.productoTextBox.Location = new System.Drawing.Point(242, 71);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(100, 22);
            this.productoTextBox.TabIndex = 58;
            this.productoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productoTextBox_KeyPress);
            this.productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.productoTextBox_Validating);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(373, 70);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarProducto.TabIndex = 59;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "Código:";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1257, 93);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 62;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1213, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // totalUltimoCostoTextBox
            // 
            this.totalUltimoCostoTextBox.Location = new System.Drawing.Point(1141, 667);
            this.totalUltimoCostoTextBox.Name = "totalUltimoCostoTextBox";
            this.totalUltimoCostoTextBox.ReadOnly = true;
            this.totalUltimoCostoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalUltimoCostoTextBox.TabIndex = 92;
            this.totalUltimoCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalCostoPromedioTextBox
            // 
            this.totalCostoPromedioTextBox.Location = new System.Drawing.Point(785, 667);
            this.totalCostoPromedioTextBox.Name = "totalCostoPromedioTextBox";
            this.totalCostoPromedioTextBox.ReadOnly = true;
            this.totalCostoPromedioTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalCostoPromedioTextBox.TabIndex = 91;
            this.totalCostoPromedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.almacenDataGridViewTextBoxColumn,
            this.categoríaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.medidaDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.ultimoCostoDataGridViewTextBoxColumn,
            this.costoPromedioDataGridViewTextBoxColumn,
            this.valorUltimoCostoDataGridViewTextBoxColumn,
            this.valorCostoPromedioDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.stockBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatos.Location = new System.Drawing.Point(4, 141);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1297, 518);
            this.dgvDatos.TabIndex = 90;
            // 
            // almacenDataGridViewTextBoxColumn
            // 
            this.almacenDataGridViewTextBoxColumn.DataPropertyName = "Almacen";
            this.almacenDataGridViewTextBoxColumn.HeaderText = "Almacén";
            this.almacenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.almacenDataGridViewTextBoxColumn.Name = "almacenDataGridViewTextBoxColumn";
            this.almacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.almacenDataGridViewTextBoxColumn.Width = 125;
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
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 125;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Width = 125;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "Unidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.unidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.unidadDataGridViewTextBoxColumn.HeaderText = "Unidad";
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
            this.medidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.medidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medidaDataGridViewTextBoxColumn.Name = "medidaDataGridViewTextBoxColumn";
            this.medidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.medidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.stockDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // ultimoCostoDataGridViewTextBoxColumn
            // 
            this.ultimoCostoDataGridViewTextBoxColumn.DataPropertyName = "UltimoCosto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ultimoCostoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ultimoCostoDataGridViewTextBoxColumn.HeaderText = "Último Costo";
            this.ultimoCostoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ultimoCostoDataGridViewTextBoxColumn.Name = "ultimoCostoDataGridViewTextBoxColumn";
            this.ultimoCostoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultimoCostoDataGridViewTextBoxColumn.Width = 125;
            // 
            // costoPromedioDataGridViewTextBoxColumn
            // 
            this.costoPromedioDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedio";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.costoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.costoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio";
            this.costoPromedioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoPromedioDataGridViewTextBoxColumn.Name = "costoPromedioDataGridViewTextBoxColumn";
            this.costoPromedioDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoPromedioDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorUltimoCostoDataGridViewTextBoxColumn
            // 
            this.valorUltimoCostoDataGridViewTextBoxColumn.DataPropertyName = "ValorUltimoCosto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valorUltimoCostoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.valorUltimoCostoDataGridViewTextBoxColumn.HeaderText = "Valor Último Costo";
            this.valorUltimoCostoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorUltimoCostoDataGridViewTextBoxColumn.Name = "valorUltimoCostoDataGridViewTextBoxColumn";
            this.valorUltimoCostoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUltimoCostoDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorCostoPromedioDataGridViewTextBoxColumn
            // 
            this.valorCostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "ValorCostoPromedio";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valorCostoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.valorCostoPromedioDataGridViewTextBoxColumn.HeaderText = "Valor Costo Promedio";
            this.valorCostoPromedioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorCostoPromedioDataGridViewTextBoxColumn.Name = "valorCostoPromedioDataGridViewTextBoxColumn";
            this.valorCostoPromedioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorCostoPromedioDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(982, 670);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 94;
            this.label5.Text = "Total Último Costo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(603, 670);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 17);
            this.label13.TabIndex = 93;
            this.label13.Text = "Total Costo Promedio:";
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(871, 1);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(141, 132);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 95;
            this.pbxImagen.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1321, 709);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.totalUltimoCostoTextBox);
            this.Controls.Add(this.totalCostoPromedioTextBox);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.productoLabel);
            this.Controls.Add(this.productoTextBox);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productosCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.almacenesCheckBox);
            this.Controls.Add(this.categoriasCheckBox);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Stock---";
            this.Load += new System.EventHandler(this.frmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox categoriasCheckBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox almacenesCheckBox;
        private System.Windows.Forms.CheckBox productosCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productoLabel;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox totalUltimoCostoTextBox;
        private System.Windows.Forms.TextBox totalCostoPromedioTextBox;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DSMiAppComercialTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DSMiAppComercialTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoríaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoCostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPromedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUltimoCostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCostoPromedioDataGridViewTextBoxColumn;
    }
}