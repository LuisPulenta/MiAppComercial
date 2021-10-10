
namespace Win.Consultas
{
    partial class frmConsultaCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCompras));
            this.resetDesdeButton = new System.Windows.Forms.Button();
            this.resetHastaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.label2 = new System.Windows.Forms.Label();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.iDCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacénDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraBusquedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            this.proveedorTableAdapter = new Win.DSMiAppComercialTableAdapters.ProveedorTableAdapter();
            this.dSMiAppComercialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compraBusquedaTableAdapter = new Win.DSMiAppComercialTableAdapters.CompraBusquedaTableAdapter();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.proveedoresCheckBox = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.totalNetoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBusquedaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // resetDesdeButton
            // 
            this.resetDesdeButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetDesdeButton.Location = new System.Drawing.Point(363, 76);
            this.resetDesdeButton.Name = "resetDesdeButton";
            this.resetDesdeButton.Size = new System.Drawing.Size(56, 24);
            this.resetDesdeButton.TabIndex = 21;
            this.resetDesdeButton.Text = "RESET";
            this.resetDesdeButton.UseVisualStyleBackColor = true;
            this.resetDesdeButton.Click += new System.EventHandler(this.resetDesdeButton_Click);
            // 
            // resetHastaButton
            // 
            this.resetHastaButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetHastaButton.Location = new System.Drawing.Point(363, 105);
            this.resetHastaButton.Name = "resetHastaButton";
            this.resetHastaButton.Size = new System.Drawing.Size(56, 24);
            this.resetHastaButton.TabIndex = 24;
            this.resetHastaButton.Text = "RESET";
            this.resetHastaButton.UseVisualStyleBackColor = true;
            this.resetHastaButton.Click += new System.EventHandler(this.resetHastaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hasta:";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Location = new System.Drawing.Point(94, 106);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.hastaDateTimePicker.TabIndex = 23;
            this.hastaDateTimePicker.ValueChanged += new System.EventHandler(this.hastaDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Desde:";
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Location = new System.Drawing.Point(94, 77);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.desdeDateTimePicker.TabIndex = 20;
            this.desdeDateTimePicker.ValueChanged += new System.EventHandler(this.desdeDateTimePicker_ValueChanged);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Enabled = false;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(520, 48);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarProveedor.TabIndex = 18;
            this.btnBuscarProveedor.Text = "...";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // proveedorComboBox
            // 
            this.proveedorComboBox.DataSource = this.proveedorBindingSource;
            this.proveedorComboBox.DisplayMember = "Nombre";
            this.proveedorComboBox.Enabled = false;
            this.proveedorComboBox.FormattingEnabled = true;
            this.proveedorComboBox.Location = new System.Drawing.Point(172, 48);
            this.proveedorComboBox.Name = "proveedorComboBox";
            this.proveedorComboBox.Size = new System.Drawing.Size(321, 24);
            this.proveedorComboBox.TabIndex = 17;
            this.proveedorComboBox.ValueMember = "IDProveedor";
            this.proveedorComboBox.SelectedIndexChanged += new System.EventHandler(this.proveedorComboBox_SelectedIndexChanged);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // dSMiAppComercial
            // 
            this.dSMiAppComercial.DataSetName = "DSMiAppComercial";
            this.dSMiAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Proveedor:";
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataSource = this.almacenBindingSource;
            this.almacenComboBox.DisplayMember = "Descripcion";
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(94, 16);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(263, 24);
            this.almacenComboBox.TabIndex = 15;
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
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 14;
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
            this.iDCompraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.almacénDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.ValorBruto,
            this.ValorIVA,
            this.ValorDescuento,
            this.ValorNeto});
            this.dgvDatos.DataSource = this.compraBusquedaBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatos.Location = new System.Drawing.Point(1, 159);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1302, 494);
            this.dgvDatos.TabIndex = 25;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // iDCompraDataGridViewTextBoxColumn
            // 
            this.iDCompraDataGridViewTextBoxColumn.DataPropertyName = "IDCompra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDCompraDataGridViewTextBoxColumn.HeaderText = "Compra";
            this.iDCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCompraDataGridViewTextBoxColumn.Name = "iDCompraDataGridViewTextBoxColumn";
            this.iDCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedorDataGridViewTextBoxColumn.Width = 125;
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
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.itemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemsDataGridViewTextBoxColumn.Width = 125;
            // 
            // ValorBruto
            // 
            this.ValorBruto.DataPropertyName = "ValorBruto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ValorBruto.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorBruto.HeaderText = "Valor Bruto";
            this.ValorBruto.MinimumWidth = 6;
            this.ValorBruto.Name = "ValorBruto";
            this.ValorBruto.ReadOnly = true;
            this.ValorBruto.Width = 125;
            // 
            // ValorIVA
            // 
            this.ValorIVA.DataPropertyName = "ValorIVA";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ValorIVA.DefaultCellStyle = dataGridViewCellStyle5;
            this.ValorIVA.HeaderText = "Valor IVA";
            this.ValorIVA.MinimumWidth = 6;
            this.ValorIVA.Name = "ValorIVA";
            this.ValorIVA.ReadOnly = true;
            this.ValorIVA.Width = 125;
            // 
            // ValorDescuento
            // 
            this.ValorDescuento.DataPropertyName = "ValorDescuento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ValorDescuento.DefaultCellStyle = dataGridViewCellStyle6;
            this.ValorDescuento.HeaderText = "ValorDescuento";
            this.ValorDescuento.MinimumWidth = 6;
            this.ValorDescuento.Name = "ValorDescuento";
            this.ValorDescuento.ReadOnly = true;
            this.ValorDescuento.Width = 125;
            // 
            // ValorNeto
            // 
            this.ValorNeto.DataPropertyName = "ValorNeto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ValorNeto.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValorNeto.HeaderText = "Valor Neto";
            this.ValorNeto.MinimumWidth = 6;
            this.ValorNeto.Name = "ValorNeto";
            this.ValorNeto.ReadOnly = true;
            this.ValorNeto.Width = 125;
            // 
            // compraBusquedaBindingSource
            // 
            this.compraBusquedaBindingSource.DataMember = "CompraBusqueda";
            this.compraBusquedaBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // dSMiAppComercialBindingSource
            // 
            this.dSMiAppComercialBindingSource.DataSource = this.dSMiAppComercial;
            this.dSMiAppComercialBindingSource.Position = 0;
            // 
            // compraBusquedaTableAdapter
            // 
            this.compraBusquedaTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1257, 102);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 27;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1213, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // proveedoresCheckBox
            // 
            this.proveedoresCheckBox.AutoSize = true;
            this.proveedoresCheckBox.Checked = true;
            this.proveedoresCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.proveedoresCheckBox.Location = new System.Drawing.Point(96, 50);
            this.proveedoresCheckBox.Name = "proveedoresCheckBox";
            this.proveedoresCheckBox.Size = new System.Drawing.Size(70, 21);
            this.proveedoresCheckBox.TabIndex = 28;
            this.proveedoresCheckBox.Text = "Todos";
            this.proveedoresCheckBox.UseVisualStyleBackColor = true;
            this.proveedoresCheckBox.CheckedChanged += new System.EventHandler(this.proveedoresCheckBox_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(997, 662);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 17);
            this.label13.TabIndex = 71;
            this.label13.Text = "Total Valor Neto:";
            // 
            // totalNetoTextBox
            // 
            this.totalNetoTextBox.Location = new System.Drawing.Point(1143, 659);
            this.totalNetoTextBox.Name = "totalNetoTextBox";
            this.totalNetoTextBox.ReadOnly = true;
            this.totalNetoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalNetoTextBox.TabIndex = 70;
            this.totalNetoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 15);
            this.label5.TabIndex = 72;
            this.label5.Text = "Haga DOBLE CLIC en una fila para ver el Detalle de una Compra";
            // 
            // frmConsultaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1305, 693);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.totalNetoTextBox);
            this.Controls.Add(this.proveedoresCheckBox);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resetDesdeButton);
            this.Controls.Add(this.resetHastaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.proveedorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Consulta de Compras---";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaCompras_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultaCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraBusquedaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetDesdeButton;
        private System.Windows.Forms.Button resetHastaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.ComboBox proveedorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDatos;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DSMiAppComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource compraBusquedaBindingSource;
        private System.Windows.Forms.BindingSource dSMiAppComercialBindingSource;
        private DSMiAppComercialTableAdapters.CompraBusquedaTableAdapter compraBusquedaTableAdapter;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox proveedoresCheckBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalNetoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacénDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorNeto;
    }
}