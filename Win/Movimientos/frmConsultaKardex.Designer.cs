
namespace Win.Movimientos
{
    partial class frmConsultaKardex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaKardex));
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productoLabel = new System.Windows.Forms.Label();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoPromedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            this.kardexTableAdapter = new Win.DSMiAppComercialTableAdapters.KardexTableAdapter();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resetHastaButton = new System.Windows.Forms.Button();
            this.resetDesdeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(763, 12);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(191, 173);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 33;
            this.pbxImagen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Almacen:";
            // 
            // productoLabel
            // 
            this.productoLabel.AutoSize = true;
            this.productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLabel.ForeColor = System.Drawing.Color.Blue;
            this.productoLabel.Location = new System.Drawing.Point(280, 65);
            this.productoLabel.Name = "productoLabel";
            this.productoLabel.Size = new System.Drawing.Size(190, 17);
            this.productoLabel.TabIndex = 32;
            this.productoLabel.Text = "Descripción del Producto";
            // 
            // productoTextBox
            // 
            this.productoTextBox.Location = new System.Drawing.Point(91, 61);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(100, 22);
            this.productoTextBox.TabIndex = 30;
            this.productoTextBox.Validated += new System.EventHandler(this.productoTextBox_Validated);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(229, 60);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarProducto.TabIndex = 31;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Producto:";
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataSource = this.almacenBindingSource;
            this.almacenComboBox.DisplayMember = "Descripcion";
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(91, 31);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(263, 24);
            this.almacenComboBox.TabIndex = 28;
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
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.entradaDataGridViewTextBoxColumn,
            this.salidaDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.ultimoCostoDataGridViewTextBoxColumn,
            this.costoPromedioDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.kardexBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatos.Location = new System.Drawing.Point(1, 191);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(961, 473);
            this.dgvDatos.TabIndex = 26;
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
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // entradaDataGridViewTextBoxColumn
            // 
            this.entradaDataGridViewTextBoxColumn.DataPropertyName = "Entrada";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.entradaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.entradaDataGridViewTextBoxColumn.HeaderText = "Entrada";
            this.entradaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.entradaDataGridViewTextBoxColumn.Name = "entradaDataGridViewTextBoxColumn";
            this.entradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.entradaDataGridViewTextBoxColumn.Width = 125;
            // 
            // salidaDataGridViewTextBoxColumn
            // 
            this.salidaDataGridViewTextBoxColumn.DataPropertyName = "Salida";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.salidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.salidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.salidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salidaDataGridViewTextBoxColumn.Name = "salidaDataGridViewTextBoxColumn";
            this.salidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.salidaDataGridViewTextBoxColumn.Width = 125;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.saldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            this.saldoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ultimoCostoDataGridViewTextBoxColumn
            // 
            this.ultimoCostoDataGridViewTextBoxColumn.DataPropertyName = "UltimoCosto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.ultimoCostoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.ultimoCostoDataGridViewTextBoxColumn.HeaderText = "Ultimo Costo";
            this.ultimoCostoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ultimoCostoDataGridViewTextBoxColumn.Name = "ultimoCostoDataGridViewTextBoxColumn";
            this.ultimoCostoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ultimoCostoDataGridViewTextBoxColumn.Width = 125;
            // 
            // costoPromedioDataGridViewTextBoxColumn
            // 
            this.costoPromedioDataGridViewTextBoxColumn.DataPropertyName = "CostoPromedio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.costoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.costoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio";
            this.costoPromedioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costoPromedioDataGridViewTextBoxColumn.Name = "costoPromedioDataGridViewTextBoxColumn";
            this.costoPromedioDataGridViewTextBoxColumn.ReadOnly = true;
            this.costoPromedioDataGridViewTextBoxColumn.Width = 125;
            // 
            // kardexBindingSource
            // 
            this.kardexBindingSource.DataMember = "Kardex";
            this.kardexBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // kardexTableAdapter
            // 
            this.kardexTableAdapter.ClearBeforeFill = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(654, 145);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 35;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(654, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 56;
            this.label1.Text = "Hasta:";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Location = new System.Drawing.Point(91, 121);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.hastaDateTimePicker.TabIndex = 57;
            this.hastaDateTimePicker.ValueChanged += new System.EventHandler(this.hastaDateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Desde:";
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Location = new System.Drawing.Point(91, 92);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.desdeDateTimePicker.TabIndex = 55;
            this.desdeDateTimePicker.ValueChanged += new System.EventHandler(this.desdeDateTimePicker_ValueChanged);
            // 
            // resetHastaButton
            // 
            this.resetHastaButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetHastaButton.Location = new System.Drawing.Point(360, 120);
            this.resetHastaButton.Name = "resetHastaButton";
            this.resetHastaButton.Size = new System.Drawing.Size(56, 24);
            this.resetHastaButton.TabIndex = 58;
            this.resetHastaButton.Text = "RESET";
            this.resetHastaButton.UseVisualStyleBackColor = true;
            this.resetHastaButton.Click += new System.EventHandler(this.resetHastaButton_Click);
            // 
            // resetDesdeButton
            // 
            this.resetDesdeButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetDesdeButton.Location = new System.Drawing.Point(360, 91);
            this.resetDesdeButton.Name = "resetDesdeButton";
            this.resetDesdeButton.Size = new System.Drawing.Size(56, 24);
            this.resetDesdeButton.TabIndex = 59;
            this.resetDesdeButton.Text = "RESET";
            this.resetDesdeButton.UseVisualStyleBackColor = true;
            this.resetDesdeButton.Click += new System.EventHandler(this.resetDesdeButton_Click);
            // 
            // frmConsultaKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(962, 670);
            this.Controls.Add(this.resetDesdeButton);
            this.Controls.Add(this.resetHastaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desdeDateTimePicker);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productoLabel);
            this.Controls.Add(this.productoTextBox);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaKardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Consulta Kardex---";
            this.Load += new System.EventHandler(this.frmConsultaKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label productoLabel;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.BindingSource kardexBindingSource;
        private DSMiAppComercialTableAdapters.KardexTableAdapter kardexTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoCostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoPromedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private System.Windows.Forms.Button resetDesdeButton;
        private System.Windows.Forms.Button resetHastaButton;
    }
}