
namespace Win.Consultas
{
    partial class frmConsultaDevolucionAClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDevolucionAClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalUltimoCostoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.totalCostoPromedioTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clientesCheckBox = new System.Windows.Forms.CheckBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.resetHastaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.resetDesdeButton = new System.Windows.Forms.Button();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            this.clienteTableAdapter = new Win.DSMiAppComercialTableAdapters.ClienteTableAdapter();
            this.devolucionAClientesConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devolucionAClientesConsultaTableAdapter = new Win.DSMiAppComercialTableAdapters.DevolucionAClientesConsultaTableAdapter();
            this.devoluciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacénDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCostoPromedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUltimoCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionAClientesConsultaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalUltimoCostoTextBox
            // 
            this.totalUltimoCostoTextBox.Location = new System.Drawing.Point(1030, 670);
            this.totalUltimoCostoTextBox.Name = "totalUltimoCostoTextBox";
            this.totalUltimoCostoTextBox.ReadOnly = true;
            this.totalUltimoCostoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalUltimoCostoTextBox.TabIndex = 113;
            this.totalUltimoCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(878, 673);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 114;
            this.label6.Text = "Total Último Costo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(499, 673);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 17);
            this.label13.TabIndex = 112;
            this.label13.Text = "Total Costo Promedio:";
            // 
            // totalCostoPromedioTextBox
            // 
            this.totalCostoPromedioTextBox.Location = new System.Drawing.Point(674, 670);
            this.totalCostoPromedioTextBox.Name = "totalCostoPromedioTextBox";
            this.totalCostoPromedioTextBox.ReadOnly = true;
            this.totalCostoPromedioTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalCostoPromedioTextBox.TabIndex = 111;
            this.totalCostoPromedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(22, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 15);
            this.label5.TabIndex = 110;
            this.label5.Text = "Haga DOBLE CLIC en una fila para ver el Detalle de una Devolución de Cliente";
            // 
            // clientesCheckBox
            // 
            this.clientesCheckBox.AutoSize = true;
            this.clientesCheckBox.Checked = true;
            this.clientesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clientesCheckBox.Location = new System.Drawing.Point(106, 53);
            this.clientesCheckBox.Name = "clientesCheckBox";
            this.clientesCheckBox.Size = new System.Drawing.Size(70, 21);
            this.clientesCheckBox.TabIndex = 109;
            this.clientesCheckBox.Text = "Todos";
            this.clientesCheckBox.UseVisualStyleBackColor = true;
            this.clientesCheckBox.CheckedChanged += new System.EventHandler(this.clientesCheckBox_CheckedChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1147, 101);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 108;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1103, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 107;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 95;
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
            this.devoluciónDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.ventaDataGridViewTextBoxColumn,
            this.fechaVentaDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.almacénDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.valorCostoPromedioDataGridViewTextBoxColumn,
            this.valorUltimoCostoDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.devolucionAClientesConsultaBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatos.Location = new System.Drawing.Point(11, 162);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1179, 494);
            this.dgvDatos.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "Cliente:";
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataSource = this.almacenBindingSource;
            this.almacenComboBox.DisplayMember = "Descripcion";
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(104, 19);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(263, 24);
            this.almacenComboBox.TabIndex = 96;
            this.almacenComboBox.ValueMember = "IDAlmacen";
            this.almacenComboBox.SelectedIndexChanged += new System.EventHandler(this.almacenComboBox_SelectedIndexChanged);
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "Almacen";
            this.almacenBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // dSMiAppComercial
            // 
            this.dSMiAppComercial.DataSetName = "DSMiAppComercial";
            this.dSMiAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resetHastaButton
            // 
            this.resetHastaButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetHastaButton.Location = new System.Drawing.Point(373, 108);
            this.resetHastaButton.Name = "resetHastaButton";
            this.resetHastaButton.Size = new System.Drawing.Size(56, 24);
            this.resetHastaButton.TabIndex = 105;
            this.resetHastaButton.Text = "RESET";
            this.resetHastaButton.UseVisualStyleBackColor = true;
            this.resetHastaButton.Click += new System.EventHandler(this.resetHastaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 103;
            this.label4.Text = "Hasta:";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Location = new System.Drawing.Point(104, 109);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.hastaDateTimePicker.TabIndex = 104;
            this.hastaDateTimePicker.ValueChanged += new System.EventHandler(this.hastaDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Desde:";
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Location = new System.Drawing.Point(104, 80);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.desdeDateTimePicker.TabIndex = 101;
            this.desdeDateTimePicker.ValueChanged += new System.EventHandler(this.desdeDateTimePicker_ValueChanged);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Enabled = false;
            this.btnBuscarCliente.Location = new System.Drawing.Point(530, 51);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarCliente.TabIndex = 99;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // resetDesdeButton
            // 
            this.resetDesdeButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetDesdeButton.Location = new System.Drawing.Point(373, 79);
            this.resetDesdeButton.Name = "resetDesdeButton";
            this.resetDesdeButton.Size = new System.Drawing.Size(56, 24);
            this.resetDesdeButton.TabIndex = 102;
            this.resetDesdeButton.Text = "RESET";
            this.resetDesdeButton.UseVisualStyleBackColor = true;
            this.resetDesdeButton.Click += new System.EventHandler(this.resetDesdeButton_Click);
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataSource = this.clienteBindingSource;
            this.clienteComboBox.DisplayMember = "NombreComercial";
            this.clienteComboBox.Enabled = false;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(182, 51);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(321, 24);
            this.clienteComboBox.TabIndex = 98;
            this.clienteComboBox.ValueMember = "IDCliente";
            this.clienteComboBox.SelectedIndexChanged += new System.EventHandler(this.clienteComboBox_SelectedIndexChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // devolucionAClientesConsultaBindingSource
            // 
            this.devolucionAClientesConsultaBindingSource.DataMember = "DevolucionAClientesConsulta";
            this.devolucionAClientesConsultaBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // devolucionAClientesConsultaTableAdapter
            // 
            this.devolucionAClientesConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // devoluciónDataGridViewTextBoxColumn
            // 
            this.devoluciónDataGridViewTextBoxColumn.DataPropertyName = "Devolución";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.devoluciónDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.devoluciónDataGridViewTextBoxColumn.HeaderText = "Devolución";
            this.devoluciónDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devoluciónDataGridViewTextBoxColumn.Name = "devoluciónDataGridViewTextBoxColumn";
            this.devoluciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.devoluciónDataGridViewTextBoxColumn.Width = 125;
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
            // ventaDataGridViewTextBoxColumn
            // 
            this.ventaDataGridViewTextBoxColumn.DataPropertyName = "Venta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ventaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ventaDataGridViewTextBoxColumn.HeaderText = "Venta";
            this.ventaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ventaDataGridViewTextBoxColumn.Name = "ventaDataGridViewTextBoxColumn";
            this.ventaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ventaDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaVentaDataGridViewTextBoxColumn
            // 
            this.fechaVentaDataGridViewTextBoxColumn.DataPropertyName = "Fecha Venta";
            this.fechaVentaDataGridViewTextBoxColumn.HeaderText = "Fecha Venta";
            this.fechaVentaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaVentaDataGridViewTextBoxColumn.Name = "fechaVentaDataGridViewTextBoxColumn";
            this.fechaVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaVentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteDataGridViewTextBoxColumn.Width = 125;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemsDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.itemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemsDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorCostoPromedioDataGridViewTextBoxColumn
            // 
            this.valorCostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "ValorCostoPromedio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valorCostoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorCostoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio";
            this.valorCostoPromedioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorCostoPromedioDataGridViewTextBoxColumn.Name = "valorCostoPromedioDataGridViewTextBoxColumn";
            this.valorCostoPromedioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorCostoPromedioDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorUltimoCostoDataGridViewTextBoxColumn
            // 
            this.valorUltimoCostoDataGridViewTextBoxColumn.DataPropertyName = "ValorUltimoCosto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valorUltimoCostoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorUltimoCostoDataGridViewTextBoxColumn.HeaderText = "Último Costo";
            this.valorUltimoCostoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorUltimoCostoDataGridViewTextBoxColumn.Name = "valorUltimoCostoDataGridViewTextBoxColumn";
            this.valorUltimoCostoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUltimoCostoDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmConsultaDevolucionAClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1210, 712);
            this.Controls.Add(this.totalUltimoCostoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.totalCostoPromedioTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientesCheckBox);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.resetHastaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.resetDesdeButton);
            this.Controls.Add(this.clienteComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaDevolucionAClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Consulta Devolución de Clientes---";
            this.Load += new System.EventHandler(this.frmConsultaDevolucionAClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionAClientesConsultaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalUltimoCostoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalCostoPromedioTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox clientesCheckBox;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.Button resetHastaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button resetDesdeButton;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DSMiAppComercialTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource devolucionAClientesConsultaBindingSource;
        private DSMiAppComercialTableAdapters.DevolucionAClientesConsultaTableAdapter devolucionAClientesConsultaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn devoluciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacénDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCostoPromedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUltimoCostoDataGridViewTextBoxColumn;
    }
}