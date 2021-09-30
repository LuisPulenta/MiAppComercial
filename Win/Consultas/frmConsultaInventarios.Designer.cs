
namespace Win.Consultas
{
    partial class frmConsultaInventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaInventarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacénDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoríaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsOk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsConSobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsConFaltantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobranteAÚltimoCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaltanteAÚltimoCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SobranteACostoPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaltanteACostoPromedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventariosConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetHastaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resetDesdeButton = new System.Windows.Forms.Button();
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            this.totalFaltanteUltimoCostoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalFaltanteCostoPromedioTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.inventariosConsultaTableAdapter = new Win.DSMiAppComercialTableAdapters.InventariosConsultaTableAdapter();
            this.totalSobranteUltimoCostoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.totalSobranteCostoPromedioTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 15);
            this.label5.TabIndex = 90;
            this.label5.Text = "Haga DOBLE CLIC en una fila para ver el Detalle de un Inventario Físico";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(1257, 94);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 86;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1213, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 73;
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
            this.Inventario,
            this.fechaDataGridViewTextBoxColumn,
            this.almacénDataGridViewTextBoxColumn,
            this.categoríaDataGridViewTextBoxColumn,
            this.Items,
            this.ItemsOk,
            this.ItemsConSobrante,
            this.ItemsConFaltantes,
            this.SobranteAÚltimoCosto,
            this.FaltanteAÚltimoCosto,
            this.SobranteACostoPromedio,
            this.FaltanteACostoPromedio});
            this.dgvDatos.DataSource = this.inventariosConsultaBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDatos.Location = new System.Drawing.Point(2, 137);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1303, 496);
            this.dgvDatos.TabIndex = 84;
            // 
            // Inventario
            // 
            this.Inventario.DataPropertyName = "IDInventario";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Inventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.Inventario.HeaderText = "Inventario";
            this.Inventario.MinimumWidth = 6;
            this.Inventario.Name = "Inventario";
            this.Inventario.ReadOnly = true;
            this.Inventario.Width = 125;
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
            // Items
            // 
            this.Items.DataPropertyName = "Items";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Items.DefaultCellStyle = dataGridViewCellStyle3;
            this.Items.HeaderText = "Items";
            this.Items.MinimumWidth = 6;
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.Width = 125;
            // 
            // ItemsOk
            // 
            this.ItemsOk.DataPropertyName = "Items Ok";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemsOk.DefaultCellStyle = dataGridViewCellStyle4;
            this.ItemsOk.HeaderText = "Items Ok";
            this.ItemsOk.MinimumWidth = 6;
            this.ItemsOk.Name = "ItemsOk";
            this.ItemsOk.ReadOnly = true;
            this.ItemsOk.Width = 125;
            // 
            // ItemsConSobrante
            // 
            this.ItemsConSobrante.DataPropertyName = "Items con Sobrante";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemsConSobrante.DefaultCellStyle = dataGridViewCellStyle5;
            this.ItemsConSobrante.HeaderText = "Items con Sobrante";
            this.ItemsConSobrante.MinimumWidth = 6;
            this.ItemsConSobrante.Name = "ItemsConSobrante";
            this.ItemsConSobrante.ReadOnly = true;
            this.ItemsConSobrante.Width = 125;
            // 
            // ItemsConFaltantes
            // 
            this.ItemsConFaltantes.DataPropertyName = "Items con Faltantes";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.ItemsConFaltantes.DefaultCellStyle = dataGridViewCellStyle6;
            this.ItemsConFaltantes.HeaderText = "Items con Faltantes";
            this.ItemsConFaltantes.MinimumWidth = 6;
            this.ItemsConFaltantes.Name = "ItemsConFaltantes";
            this.ItemsConFaltantes.ReadOnly = true;
            this.ItemsConFaltantes.Width = 125;
            // 
            // SobranteAÚltimoCosto
            // 
            this.SobranteAÚltimoCosto.DataPropertyName = "SobranteValorUltimoCosto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.SobranteAÚltimoCosto.DefaultCellStyle = dataGridViewCellStyle7;
            this.SobranteAÚltimoCosto.HeaderText = "Sobrante a Último Costo";
            this.SobranteAÚltimoCosto.MinimumWidth = 6;
            this.SobranteAÚltimoCosto.Name = "SobranteAÚltimoCosto";
            this.SobranteAÚltimoCosto.ReadOnly = true;
            this.SobranteAÚltimoCosto.Width = 125;
            // 
            // FaltanteAÚltimoCosto
            // 
            this.FaltanteAÚltimoCosto.DataPropertyName = "FaltanteValorUltimoCosto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.FaltanteAÚltimoCosto.DefaultCellStyle = dataGridViewCellStyle8;
            this.FaltanteAÚltimoCosto.HeaderText = "Faltante a Último Costo";
            this.FaltanteAÚltimoCosto.MinimumWidth = 6;
            this.FaltanteAÚltimoCosto.Name = "FaltanteAÚltimoCosto";
            this.FaltanteAÚltimoCosto.ReadOnly = true;
            this.FaltanteAÚltimoCosto.Width = 125;
            // 
            // SobranteACostoPromedio
            // 
            this.SobranteACostoPromedio.DataPropertyName = "SobranteValorCostoPromedio";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.SobranteACostoPromedio.DefaultCellStyle = dataGridViewCellStyle9;
            this.SobranteACostoPromedio.HeaderText = "Sobrante a Costo Promedio";
            this.SobranteACostoPromedio.MinimumWidth = 6;
            this.SobranteACostoPromedio.Name = "SobranteACostoPromedio";
            this.SobranteACostoPromedio.ReadOnly = true;
            this.SobranteACostoPromedio.Width = 125;
            // 
            // FaltanteACostoPromedio
            // 
            this.FaltanteACostoPromedio.DataPropertyName = "FaltanteValorCostoPromedio";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.FaltanteACostoPromedio.DefaultCellStyle = dataGridViewCellStyle10;
            this.FaltanteACostoPromedio.HeaderText = "Faltante a Costo Promedio";
            this.FaltanteACostoPromedio.MinimumWidth = 6;
            this.FaltanteACostoPromedio.Name = "FaltanteACostoPromedio";
            this.FaltanteACostoPromedio.ReadOnly = true;
            this.FaltanteACostoPromedio.Width = 125;
            // 
            // inventariosConsultaBindingSource
            // 
            this.inventariosConsultaBindingSource.DataMember = "InventariosConsulta";
            this.inventariosConsultaBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // dSMiAppComercial
            // 
            this.dSMiAppComercial.DataSetName = "DSMiAppComercial";
            this.dSMiAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataSource = this.almacenBindingSource;
            this.almacenComboBox.DisplayMember = "Descripcion";
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(95, 18);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(263, 24);
            this.almacenComboBox.TabIndex = 74;
            this.almacenComboBox.ValueMember = "IDAlmacen";
            this.almacenComboBox.SelectedIndexChanged += new System.EventHandler(this.almacenComboBox_SelectedIndexChanged);
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "Almacen";
            this.almacenBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // resetHastaButton
            // 
            this.resetHastaButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetHastaButton.Location = new System.Drawing.Point(364, 76);
            this.resetHastaButton.Name = "resetHastaButton";
            this.resetHastaButton.Size = new System.Drawing.Size(56, 24);
            this.resetHastaButton.TabIndex = 83;
            this.resetHastaButton.Text = "RESET";
            this.resetHastaButton.UseVisualStyleBackColor = true;
            this.resetHastaButton.Click += new System.EventHandler(this.resetHastaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Hasta:";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Location = new System.Drawing.Point(95, 77);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.hastaDateTimePicker.TabIndex = 82;
            this.hastaDateTimePicker.ValueChanged += new System.EventHandler(this.hastaDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Desde:";
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Location = new System.Drawing.Point(95, 48);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.desdeDateTimePicker.TabIndex = 79;
            this.desdeDateTimePicker.ValueChanged += new System.EventHandler(this.desdeDateTimePicker_ValueChanged);
            // 
            // resetDesdeButton
            // 
            this.resetDesdeButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetDesdeButton.Location = new System.Drawing.Point(364, 47);
            this.resetDesdeButton.Name = "resetDesdeButton";
            this.resetDesdeButton.Size = new System.Drawing.Size(56, 24);
            this.resetDesdeButton.TabIndex = 80;
            this.resetDesdeButton.Text = "RESET";
            this.resetDesdeButton.UseVisualStyleBackColor = true;
            this.resetDesdeButton.Click += new System.EventHandler(this.resetDesdeButton_Click);
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // totalFaltanteUltimoCostoTextBox
            // 
            this.totalFaltanteUltimoCostoTextBox.Location = new System.Drawing.Point(1145, 639);
            this.totalFaltanteUltimoCostoTextBox.Name = "totalFaltanteUltimoCostoTextBox";
            this.totalFaltanteUltimoCostoTextBox.ReadOnly = true;
            this.totalFaltanteUltimoCostoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalFaltanteUltimoCostoTextBox.TabIndex = 93;
            this.totalFaltanteUltimoCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(929, 642);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 94;
            this.label2.Text = "Total Faltante Último Costo:";
            // 
            // totalFaltanteCostoPromedioTextBox
            // 
            this.totalFaltanteCostoPromedioTextBox.Location = new System.Drawing.Point(1145, 665);
            this.totalFaltanteCostoPromedioTextBox.Name = "totalFaltanteCostoPromedioTextBox";
            this.totalFaltanteCostoPromedioTextBox.ReadOnly = true;
            this.totalFaltanteCostoPromedioTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalFaltanteCostoPromedioTextBox.TabIndex = 91;
            this.totalFaltanteCostoPromedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(906, 668);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 17);
            this.label13.TabIndex = 92;
            this.label13.Text = "Total Faltante Costo Promedio:";
            // 
            // inventariosConsultaTableAdapter
            // 
            this.inventariosConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // totalSobranteUltimoCostoTextBox
            // 
            this.totalSobranteUltimoCostoTextBox.Location = new System.Drawing.Point(719, 639);
            this.totalSobranteUltimoCostoTextBox.Name = "totalSobranteUltimoCostoTextBox";
            this.totalSobranteUltimoCostoTextBox.ReadOnly = true;
            this.totalSobranteUltimoCostoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalSobranteUltimoCostoTextBox.TabIndex = 95;
            this.totalSobranteUltimoCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 17);
            this.label6.TabIndex = 96;
            this.label6.Text = "Total Sobrante Último Costo:";
            // 
            // totalSobranteCostoPromedioTextBox
            // 
            this.totalSobranteCostoPromedioTextBox.Location = new System.Drawing.Point(719, 665);
            this.totalSobranteCostoPromedioTextBox.Name = "totalSobranteCostoPromedioTextBox";
            this.totalSobranteCostoPromedioTextBox.ReadOnly = true;
            this.totalSobranteCostoPromedioTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalSobranteCostoPromedioTextBox.TabIndex = 97;
            this.totalSobranteCostoPromedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(480, 668);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 17);
            this.label7.TabIndex = 98;
            this.label7.Text = "Total Sobrante Costo Promedio:";
            // 
            // frmConsultaInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1305, 693);
            this.Controls.Add(this.totalSobranteCostoPromedioTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalSobranteUltimoCostoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalFaltanteUltimoCostoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalFaltanteCostoPromedioTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.resetHastaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.resetDesdeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaInventarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Consulta de Inventarios Físicos---";
            this.Load += new System.EventHandler(this.frmConsultaInventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventariosConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.Button resetHastaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.Button resetDesdeButton;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.TextBox totalFaltanteUltimoCostoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalFaltanteCostoPromedioTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource inventariosConsultaBindingSource;
        private DSMiAppComercialTableAdapters.InventariosConsultaTableAdapter inventariosConsultaTableAdapter;
        private System.Windows.Forms.TextBox totalSobranteUltimoCostoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalSobranteCostoPromedioTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacénDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoríaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsConSobrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemsConFaltantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobranteAÚltimoCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaltanteAÚltimoCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SobranteACostoPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaltanteACostoPromedio;
    }
}