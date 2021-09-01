
namespace Win.Movimientos
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.eliminarTodoButton = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalNetoTextBox = new System.Windows.Forms.TextBox();
            this.totalDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.totalIVATextBox = new System.Windows.Forms.TextBox();
            this.totalBrutoTextBox = new System.Windows.Forms.TextBox();
            this.totalItemTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.porcentajeDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eliminarLineaButton = new System.Windows.Forms.Button();
            this.agregarButton = new System.Windows.Forms.Button();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.productoLabel = new System.Windows.Forms.Label();
            this.productoTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.almacenComboBox = new System.Windows.Forms.ComboBox();
            this.almacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.proveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.proveedorTableAdapter = new Win.DSMiAppComercialTableAdapters.ProveedorTableAdapter();
            this.almacenTableAdapter = new Win.DSMiAppComercialTableAdapters.AlmacenTableAdapter();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // eliminarTodoButton
            // 
            this.eliminarTodoButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarTodoButton.Image")));
            this.eliminarTodoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarTodoButton.Location = new System.Drawing.Point(809, 137);
            this.eliminarTodoButton.Name = "eliminarTodoButton";
            this.eliminarTodoButton.Size = new System.Drawing.Size(132, 48);
            this.eliminarTodoButton.TabIndex = 73;
            this.eliminarTodoButton.Text = "Elim. Todo";
            this.eliminarTodoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarTodoButton.UseVisualStyleBackColor = true;
            this.eliminarTodoButton.Click += new System.EventHandler(this.eliminarTodoButton_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(533, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 48);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.Image")));
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(395, 137);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(132, 48);
            this.btnGrabar.TabIndex = 71;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(970, 597);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 17);
            this.label14.TabIndex = 70;
            this.label14.Text = "Valor IVA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1173, 595);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 69;
            this.label13.Text = "Valor Neto";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1076, 595);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Valor Desc.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1076, 595);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 67;
            this.label11.Text = "Valor IVA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(864, 597);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Valor Bruto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(763, 595);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Items";
            // 
            // totalNetoTextBox
            // 
            this.totalNetoTextBox.Location = new System.Drawing.Point(1173, 617);
            this.totalNetoTextBox.Name = "totalNetoTextBox";
            this.totalNetoTextBox.ReadOnly = true;
            this.totalNetoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalNetoTextBox.TabIndex = 64;
            this.totalNetoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalDescuentoTextBox
            // 
            this.totalDescuentoTextBox.Location = new System.Drawing.Point(1067, 617);
            this.totalDescuentoTextBox.Name = "totalDescuentoTextBox";
            this.totalDescuentoTextBox.ReadOnly = true;
            this.totalDescuentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalDescuentoTextBox.TabIndex = 63;
            this.totalDescuentoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalIVATextBox
            // 
            this.totalIVATextBox.Location = new System.Drawing.Point(961, 617);
            this.totalIVATextBox.Name = "totalIVATextBox";
            this.totalIVATextBox.ReadOnly = true;
            this.totalIVATextBox.Size = new System.Drawing.Size(100, 22);
            this.totalIVATextBox.TabIndex = 62;
            this.totalIVATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalBrutoTextBox
            // 
            this.totalBrutoTextBox.Location = new System.Drawing.Point(854, 617);
            this.totalBrutoTextBox.Name = "totalBrutoTextBox";
            this.totalBrutoTextBox.ReadOnly = true;
            this.totalBrutoTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalBrutoTextBox.TabIndex = 61;
            this.totalBrutoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalItemTextBox
            // 
            this.totalItemTextBox.Location = new System.Drawing.Point(748, 617);
            this.totalItemTextBox.Name = "totalItemTextBox";
            this.totalItemTextBox.ReadOnly = true;
            this.totalItemTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalItemTextBox.TabIndex = 60;
            this.totalItemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(675, 620);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "Totales:";
            // 
            // porcentajeDescuentoTextBox
            // 
            this.porcentajeDescuentoTextBox.Location = new System.Drawing.Point(118, 192);
            this.porcentajeDescuentoTextBox.Name = "porcentajeDescuentoTextBox";
            this.porcentajeDescuentoTextBox.Size = new System.Drawing.Size(100, 22);
            this.porcentajeDescuentoTextBox.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "% Descuento:";
            // 
            // costoTextBox
            // 
            this.costoTextBox.Location = new System.Drawing.Point(118, 164);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(100, 22);
            this.costoTextBox.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Costo:";
            // 
            // eliminarLineaButton
            // 
            this.eliminarLineaButton.Image = ((System.Drawing.Image)(resources.GetObject("eliminarLineaButton.Image")));
            this.eliminarLineaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarLineaButton.Location = new System.Drawing.Point(671, 138);
            this.eliminarLineaButton.Name = "eliminarLineaButton";
            this.eliminarLineaButton.Size = new System.Drawing.Size(132, 48);
            this.eliminarLineaButton.TabIndex = 54;
            this.eliminarLineaButton.Text = "Elim. Línea";
            this.eliminarLineaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.eliminarLineaButton.UseVisualStyleBackColor = true;
            this.eliminarLineaButton.Click += new System.EventHandler(this.eliminarLineaButton_Click);
            // 
            // agregarButton
            // 
            this.agregarButton.Image = ((System.Drawing.Image)(resources.GetObject("agregarButton.Image")));
            this.agregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.agregarButton.Location = new System.Drawing.Point(256, 136);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(132, 48);
            this.agregarButton.TabIndex = 53;
            this.agregarButton.Text = "Agregar";
            this.agregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(118, 136);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 22);
            this.cantidadTextBox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cantidad:";
            // 
            // pbxImagen
            // 
            this.pbxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImagen.Location = new System.Drawing.Point(1009, 9);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(277, 249);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 58;
            this.pbxImagen.TabStop = false;
            // 
            // productoLabel
            // 
            this.productoLabel.AutoSize = true;
            this.productoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoLabel.ForeColor = System.Drawing.Color.Blue;
            this.productoLabel.Location = new System.Drawing.Point(307, 110);
            this.productoLabel.Name = "productoLabel";
            this.productoLabel.Size = new System.Drawing.Size(190, 17);
            this.productoLabel.TabIndex = 56;
            this.productoLabel.Text = "Descripción del Producto";
            // 
            // productoTextBox
            // 
            this.productoTextBox.Location = new System.Drawing.Point(118, 106);
            this.productoTextBox.Name = "productoTextBox";
            this.productoTextBox.Size = new System.Drawing.Size(100, 22);
            this.productoTextBox.TabIndex = 46;
            this.productoTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.productoTextBox_Validating);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(256, 105);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarProducto.TabIndex = 55;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Producto:";
            // 
            // almacenComboBox
            // 
            this.almacenComboBox.DataSource = this.almacenBindingSource;
            this.almacenComboBox.DisplayMember = "Descripcion";
            this.almacenComboBox.FormattingEnabled = true;
            this.almacenComboBox.Location = new System.Drawing.Point(118, 76);
            this.almacenComboBox.Name = "almacenComboBox";
            this.almacenComboBox.Size = new System.Drawing.Size(263, 24);
            this.almacenComboBox.TabIndex = 44;
            this.almacenComboBox.ValueMember = "IDAlmacen";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Almacén:";
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(482, 46);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(45, 24);
            this.btnBuscarProveedor.TabIndex = 42;
            this.btnBuscarProveedor.Text = "...";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // proveedorComboBox
            // 
            this.proveedorComboBox.DataSource = this.proveedorBindingSource;
            this.proveedorComboBox.DisplayMember = "Nombre";
            this.proveedorComboBox.FormattingEnabled = true;
            this.proveedorComboBox.Location = new System.Drawing.Point(118, 46);
            this.proveedorComboBox.Name = "proveedorComboBox";
            this.proveedorComboBox.Size = new System.Drawing.Size(323, 24);
            this.proveedorComboBox.TabIndex = 41;
            this.proveedorComboBox.ValueMember = "IDProveedor";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Location = new System.Drawing.Point(118, 18);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.fechaDateTimePicker.TabIndex = 39;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Location = new System.Drawing.Point(8, 264);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(1298, 328);
            this.dgvDatos.TabIndex = 74;
            // 
            // frmCompras
            // 
            this.AcceptButton = this.agregarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1318, 659);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.eliminarTodoButton);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalNetoTextBox);
            this.Controls.Add(this.totalDescuentoTextBox);
            this.Controls.Add(this.totalIVATextBox);
            this.Controls.Add(this.totalBrutoTextBox);
            this.Controls.Add(this.totalItemTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.porcentajeDescuentoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eliminarLineaButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.productoLabel);
            this.Controls.Add(this.productoTextBox);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.almacenComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuscarProveedor);
            this.Controls.Add(this.proveedorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Compras---";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCompras_FormClosing);
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button eliminarTodoButton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalNetoTextBox;
        private System.Windows.Forms.TextBox totalDescuentoTextBox;
        private System.Windows.Forms.TextBox totalIVATextBox;
        private System.Windows.Forms.TextBox totalBrutoTextBox;
        private System.Windows.Forms.TextBox totalItemTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox porcentajeDescuentoTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costoTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button eliminarLineaButton;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label productoLabel;
        private System.Windows.Forms.TextBox productoTextBox;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox almacenComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.ComboBox proveedorComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.ToolTip toolTip1;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DSMiAppComercialTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.BindingSource almacenBindingSource;
        private DSMiAppComercialTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}