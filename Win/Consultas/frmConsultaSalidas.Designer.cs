
namespace Win.Consultas
{
    partial class frmConsultaSalidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSalidas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalCostoPromedioTextBox = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.salidasConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.resetDesdeButton = new System.Windows.Forms.Button();
            this.resetHastaButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.desdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            this.salidasConsultaTableAdapter = new Win.DSMiAppComercialTableAdapters.SalidasConsultaTableAdapter();
            this.totalUltimoCostoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iDSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacénDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCostoPromedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUltimoCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalCostoPromedioTextBox
            // 
            this.totalCostoPromedioTextBox.Location = new System.Drawing.Point(444, 661);
            this.totalCostoPromedioTextBox.Name = "totalCostoPromedioTextBox";
            this.totalCostoPromedioTextBox.ReadOnly = true;
            this.totalCostoPromedioTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalCostoPromedioTextBox.TabIndex = 87;
            this.totalCostoPromedioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(920, 91);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 85;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(876, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 72;
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
            this.iDSalidaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn,
            this.almacénDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.valorCostoPromedioDataGridViewTextBoxColumn,
            this.valorUltimoCostoDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.salidasConsultaBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDatos.Location = new System.Drawing.Point(2, 137);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(958, 518);
            this.dgvDatos.TabIndex = 83;
            // 
            // salidasConsultaBindingSource
            // 
            this.salidasConsultaBindingSource.DataMember = "SalidasConsulta";
            this.salidasConsultaBindingSource.DataSource = this.dSMiAppComercial;
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
            this.almacenComboBox.TabIndex = 73;
            this.almacenComboBox.ValueMember = "IDAlmacen";
            this.almacenComboBox.SelectedIndexChanged += new System.EventHandler(this.almacenComboBox_SelectedIndexChanged);
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "Almacen";
            this.almacenBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(269, 664);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 17);
            this.label13.TabIndex = 88;
            this.label13.Text = "Total Costo Promedio:";
            // 
            // resetDesdeButton
            // 
            this.resetDesdeButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetDesdeButton.Location = new System.Drawing.Point(364, 48);
            this.resetDesdeButton.Name = "resetDesdeButton";
            this.resetDesdeButton.Size = new System.Drawing.Size(56, 24);
            this.resetDesdeButton.TabIndex = 79;
            this.resetDesdeButton.Text = "RESET";
            this.resetDesdeButton.UseVisualStyleBackColor = true;
            this.resetDesdeButton.Click += new System.EventHandler(this.resetDesdeButton_Click);
            // 
            // resetHastaButton
            // 
            this.resetHastaButton.Font = new System.Drawing.Font("Arial Narrow", 7F);
            this.resetHastaButton.Location = new System.Drawing.Point(364, 77);
            this.resetHastaButton.Name = "resetHastaButton";
            this.resetHastaButton.Size = new System.Drawing.Size(56, 24);
            this.resetHastaButton.TabIndex = 82;
            this.resetHastaButton.Text = "RESET";
            this.resetHastaButton.UseVisualStyleBackColor = true;
            this.resetHastaButton.Click += new System.EventHandler(this.resetHastaButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "Hasta:";
            // 
            // hastaDateTimePicker
            // 
            this.hastaDateTimePicker.Location = new System.Drawing.Point(95, 78);
            this.hastaDateTimePicker.Name = "hastaDateTimePicker";
            this.hastaDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.hastaDateTimePicker.TabIndex = 81;
            this.hastaDateTimePicker.ValueChanged += new System.EventHandler(this.hastaDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "Desde:";
            // 
            // desdeDateTimePicker
            // 
            this.desdeDateTimePicker.Location = new System.Drawing.Point(95, 49);
            this.desdeDateTimePicker.Name = "desdeDateTimePicker";
            this.desdeDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.desdeDateTimePicker.TabIndex = 78;
            this.desdeDateTimePicker.ValueChanged += new System.EventHandler(this.desdeDateTimePicker_ValueChanged);
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // salidasConsultaTableAdapter
            // 
            this.salidasConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // totalUltimoCostoTextBox
            // 
            this.totalUltimoCostoTextBox.Location = new System.Drawing.Point(800, 661);
            this.totalUltimoCostoTextBox.Name = "totalUltimoCostoTextBox";
            this.totalUltimoCostoTextBox.ReadOnly = true;
            this.totalUltimoCostoTextBox.Size = new System.Drawing.Size(160, 22);
            this.totalUltimoCostoTextBox.TabIndex = 89;
            this.totalUltimoCostoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 664);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 90;
            this.label2.Text = "Total Último Costo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 15);
            this.label5.TabIndex = 91;
            this.label5.Text = "Haga DOBLE CLIC en una fila para ver el Detalle de una Salida";
            // 
            // iDSalidaDataGridViewTextBoxColumn
            // 
            this.iDSalidaDataGridViewTextBoxColumn.DataPropertyName = "IDSalida";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iDSalidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iDSalidaDataGridViewTextBoxColumn.HeaderText = "Salida";
            this.iDSalidaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSalidaDataGridViewTextBoxColumn.Name = "iDSalidaDataGridViewTextBoxColumn";
            this.iDSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSalidaDataGridViewTextBoxColumn.Width = 125;
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
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            this.conceptoDataGridViewTextBoxColumn.Width = 125;
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
            // valorCostoPromedioDataGridViewTextBoxColumn
            // 
            this.valorCostoPromedioDataGridViewTextBoxColumn.DataPropertyName = "ValorCostoPromedio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valorCostoPromedioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorCostoPromedioDataGridViewTextBoxColumn.HeaderText = "Costo Promedio";
            this.valorCostoPromedioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorCostoPromedioDataGridViewTextBoxColumn.Name = "valorCostoPromedioDataGridViewTextBoxColumn";
            this.valorCostoPromedioDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorCostoPromedioDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorUltimoCostoDataGridViewTextBoxColumn
            // 
            this.valorUltimoCostoDataGridViewTextBoxColumn.DataPropertyName = "ValorUltimoCosto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.valorUltimoCostoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorUltimoCostoDataGridViewTextBoxColumn.HeaderText = "Último Costo";
            this.valorUltimoCostoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorUltimoCostoDataGridViewTextBoxColumn.Name = "valorUltimoCostoDataGridViewTextBoxColumn";
            this.valorUltimoCostoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorUltimoCostoDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmConsultaSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(963, 693);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalUltimoCostoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalCostoPromedioTextBox);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.resetDesdeButton);
            this.Controls.Add(this.resetHastaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastaDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desdeDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaSalidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Consulta de Salidas---";
            this.Load += new System.EventHandler(this.frmConsultaSalidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalCostoPromedioTextBox;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button resetDesdeButton;
        private System.Windows.Forms.Button resetHastaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker hastaDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker desdeDateTimePicker;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.BindingSource salidasConsultaBindingSource;
        private DSMiAppComercialTableAdapters.SalidasConsultaTableAdapter salidasConsultaTableAdapter;
        private System.Windows.Forms.TextBox totalUltimoCostoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacénDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCostoPromedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUltimoCostoDataGridViewTextBoxColumn;
    }
}