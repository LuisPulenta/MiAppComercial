﻿
namespace Win.Movimientos
{
    partial class frmDevolucionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevolucionClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDevolverTodo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.eliminarTodoButton = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.eliminarLineaButton = new System.Windows.Forms.Button();
            this.agregarButton = new System.Windows.Forms.Button();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productoComboBox = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDatosDevuelto = new System.Windows.Forms.DataGridView();
            this.dgvDatosDisponible = new System.Windows.Forms.DataGridView();
            this.fechaDevolucionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ventaComboBox = new System.Windows.Forms.ComboBox();
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ventaTableAdapter = new Win.DSMiAppComercialTableAdapters.VentaTableAdapter();
            this.productoTableAdapter = new Win.DSMiAppComercialTableAdapters.ProductoTableAdapter();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Win.DSMiAppComercialTableAdapters.ClienteTableAdapter();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDevuelto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDisponible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevolverTodo
            // 
            this.btnDevolverTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolverTodo.Image")));
            this.btnDevolverTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevolverTodo.Location = new System.Drawing.Point(549, 366);
            this.btnDevolverTodo.Name = "btnDevolverTodo";
            this.btnDevolverTodo.Size = new System.Drawing.Size(140, 48);
            this.btnDevolverTodo.TabIndex = 45;
            this.btnDevolverTodo.Text = "Devolver Todo";
            this.btnDevolverTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevolverTodo.UseVisualStyleBackColor = true;
            this.btnDevolverTodo.Click += new System.EventHandler(this.btnDevolverTodo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Fecha Devolución:";
            // 
            // eliminarTodoButton
            // 
            this.eliminarTodoButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarTodoButton.Image")));
            this.eliminarTodoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarTodoButton.Location = new System.Drawing.Point(1127, 367);
            this.eliminarTodoButton.Name = "eliminarTodoButton";
            this.eliminarTodoButton.Size = new System.Drawing.Size(140, 48);
            this.eliminarTodoButton.TabIndex = 43;
            this.eliminarTodoButton.Text = "Elim. Todo";
            this.eliminarTodoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarTodoButton.UseVisualStyleBackColor = true;
            this.eliminarTodoButton.Click += new System.EventHandler(this.eliminarTodoButton_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(837, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 48);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(693, 367);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(140, 48);
            this.btnGrabar.TabIndex = 40;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // eliminarLineaButton
            // 
            this.eliminarLineaButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarLineaButton.Image")));
            this.eliminarLineaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarLineaButton.Location = new System.Drawing.Point(981, 368);
            this.eliminarLineaButton.Name = "eliminarLineaButton";
            this.eliminarLineaButton.Size = new System.Drawing.Size(140, 48);
            this.eliminarLineaButton.TabIndex = 42;
            this.eliminarLineaButton.Text = "Elim. Línea";
            this.eliminarLineaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarLineaButton.UseVisualStyleBackColor = true;
            this.eliminarLineaButton.Click += new System.EventHandler(this.eliminarLineaButton_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarButton.Image")));
            this.agregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarButton.Location = new System.Drawing.Point(405, 367);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(140, 48);
            this.agregarButton.TabIndex = 39;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(82, 397);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(141, 22);
            this.cantidadTextBox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cantidad:";
            // 
            // productoComboBox
            // 
            this.productoComboBox.DisplayMember = "Descripcion";
            this.productoComboBox.FormattingEnabled = true;
            this.productoComboBox.Location = new System.Drawing.Point(82, 367);
            this.productoComboBox.Name = "productoComboBox";
            this.productoComboBox.Size = new System.Drawing.Size(289, 24);
            this.productoComboBox.TabIndex = 36;
            this.productoComboBox.ValueMember = "Codigo";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // dSMiAppComercial
            // 
            this.dSMiAppComercial.DataSetName = "DSMiAppComercial";
            this.dSMiAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Producto:";
            // 
            // dgvDatosDevuelto
            // 
            this.dgvDatosDevuelto.AllowUserToAddRows = false;
            this.dgvDatosDevuelto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatosDevuelto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDatosDevuelto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosDevuelto.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatosDevuelto.Location = new System.Drawing.Point(14, 428);
            this.dgvDatosDevuelto.Name = "dgvDatosDevuelto";
            this.dgvDatosDevuelto.ReadOnly = true;
            this.dgvDatosDevuelto.RowHeadersWidth = 51;
            this.dgvDatosDevuelto.RowTemplate.Height = 24;
            this.dgvDatosDevuelto.Size = new System.Drawing.Size(1274, 208);
            this.dgvDatosDevuelto.TabIndex = 44;
            // 
            // dgvDatosDisponible
            // 
            this.dgvDatosDisponible.AllowUserToAddRows = false;
            this.dgvDatosDisponible.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDatosDisponible.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDatosDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosDisponible.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDatosDisponible.Location = new System.Drawing.Point(14, 148);
            this.dgvDatosDisponible.Name = "dgvDatosDisponible";
            this.dgvDatosDisponible.ReadOnly = true;
            this.dgvDatosDisponible.RowHeadersWidth = 51;
            this.dgvDatosDisponible.RowTemplate.Height = 24;
            this.dgvDatosDisponible.Size = new System.Drawing.Size(1274, 208);
            this.dgvDatosDisponible.TabIndex = 34;
            // 
            // fechaDevolucionDateTimePicker
            // 
            this.fechaDevolucionDateTimePicker.Location = new System.Drawing.Point(492, 41);
            this.fechaDevolucionDateTimePicker.Name = "fechaDevolucionDateTimePicker";
            this.fechaDevolucionDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.fechaDevolucionDateTimePicker.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Almacén:";
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataSource = this.almacenBindingSource;
            this.almacenComboBox.DisplayMember = "Descripcion";
            this.almacenComboBox.Enabled = false;
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(130, 96);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(323, 24);
            this.almacenComboBox.TabIndex = 33;
            this.almacenComboBox.ValueMember = "IDAlmacen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cliente:";
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DataSource = this.clienteBindingSource;
            this.clienteComboBox.DisplayMember = "NombreComercial";
            this.clienteComboBox.Enabled = false;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(130, 67);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(323, 24);
            this.clienteComboBox.TabIndex = 31;
            this.clienteComboBox.ValueMember = "IDCliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Fecha Venta:";
            // 
            // ventaComboBox
            // 
            this.ventaComboBox.DataSource = this.ventaBindingSource;
            this.ventaComboBox.DisplayMember = "Venta";
            this.ventaComboBox.FormattingEnabled = true;
            this.ventaComboBox.Location = new System.Drawing.Point(130, 12);
            this.ventaComboBox.Name = "ventaComboBox";
            this.ventaComboBox.Size = new System.Drawing.Size(525, 24);
            this.ventaComboBox.TabIndex = 24;
            this.ventaComboBox.ValueMember = "IDVenta";
            this.ventaComboBox.SelectedIndexChanged += new System.EventHandler(this.ventaComboBox_SelectedIndexChanged);
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.Location = new System.Drawing.Point(130, 41);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.ReadOnly = true;
            this.fechaTextBox.Size = new System.Drawing.Size(213, 22);
            this.fechaTextBox.TabIndex = 27;
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(689, 12);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarVenta.TabIndex = 25;
            this.btnBuscarVenta.Text = "...";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Venta:";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // almacenBindingSource
            // 
            this.almacenBindingSource.DataMember = "Almacen";
            this.almacenBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // frmDevolucionClientes
            // 
            this.AcceptButton = this.agregarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1298, 649);
            this.Controls.Add(this.btnDevolverTodo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.eliminarTodoButton);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.eliminarLineaButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.productoComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDatosDevuelto);
            this.Controls.Add(this.dgvDatosDisponible);
            this.Controls.Add(this.fechaDevolucionDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clienteComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ventaComboBox);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevolucionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Devolución de Clientes---";
            this.Load += new System.EventHandler(this.frmDevolucionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDevuelto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosDisponible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevolverTodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button eliminarTodoButton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button eliminarLineaButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox productoComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDatosDevuelto;
        private System.Windows.Forms.DataGridView dgvDatosDisponible;
        private System.Windows.Forms.DateTimePicker fechaDevolucionDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ventaComboBox;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private DSMiAppComercialTableAdapters.VentaTableAdapter ventaTableAdapter;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DSMiAppComercialTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DSMiAppComercialTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
    }
}