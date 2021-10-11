
namespace Win.Listados
{
    partial class frmListadoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoProductos));
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.label2 = new System.Windows.Forms.Label();
            this.todosCheckBox = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.productoRadioButton = new System.Windows.Forms.RadioButton();
            this.codigoRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cryProductosListado1 = new Win.Listados.cryProductosListado();
            this.verReporteButton = new System.Windows.Forms.Button();
            this.categoriaTableAdapter = new Win.DSMiAppComercialTableAdapters.CategoriaTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataSource = this.categoriaBindingSource;
            this.categoriaComboBox.DisplayMember = "Descripcion";
            this.categoriaComboBox.Enabled = false;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(167, 14);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(260, 24);
            this.categoriaComboBox.TabIndex = 26;
            this.categoriaComboBox.ValueMember = "IDCategoria";
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
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Categoría:";
            // 
            // todosCheckBox
            // 
            this.todosCheckBox.AutoSize = true;
            this.todosCheckBox.Checked = true;
            this.todosCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todosCheckBox.Location = new System.Drawing.Point(91, 17);
            this.todosCheckBox.Name = "todosCheckBox";
            this.todosCheckBox.Size = new System.Drawing.Size(70, 21);
            this.todosCheckBox.TabIndex = 28;
            this.todosCheckBox.Text = "Todas";
            this.todosCheckBox.UseVisualStyleBackColor = true;
            this.todosCheckBox.CheckedChanged += new System.EventHandler(this.todosCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.productoRadioButton);
            this.groupBox2.Controls.Add(this.codigoRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(472, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 57);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenado por";
            // 
            // productoRadioButton
            // 
            this.productoRadioButton.AutoSize = true;
            this.productoRadioButton.Location = new System.Drawing.Point(94, 22);
            this.productoRadioButton.Name = "productoRadioButton";
            this.productoRadioButton.Size = new System.Drawing.Size(163, 21);
            this.productoRadioButton.TabIndex = 1;
            this.productoRadioButton.Text = "Nombre del Producto";
            this.productoRadioButton.UseVisualStyleBackColor = true;
            // 
            // codigoRadioButton
            // 
            this.codigoRadioButton.AutoSize = true;
            this.codigoRadioButton.Checked = true;
            this.codigoRadioButton.Location = new System.Drawing.Point(6, 22);
            this.codigoRadioButton.Name = "codigoRadioButton";
            this.codigoRadioButton.Size = new System.Drawing.Size(73, 21);
            this.codigoRadioButton.TabIndex = 0;
            this.codigoRadioButton.TabStop = true;
            this.codigoRadioButton.Text = "Código";
            this.codigoRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 585);
            this.panel1.TabIndex = 31;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.cryProductosListado1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1339, 585);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // verReporteButton
            // 
            this.verReporteButton.Image = ((System.Drawing.Image)(resources.GetObject("verReporteButton.Image")));
            this.verReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.verReporteButton.Location = new System.Drawing.Point(759, 18);
            this.verReporteButton.Name = "verReporteButton";
            this.verReporteButton.Size = new System.Drawing.Size(143, 51);
            this.verReporteButton.TabIndex = 32;
            this.verReporteButton.Text = "Ver Listado";
            this.verReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.verReporteButton.UseVisualStyleBackColor = true;
            this.verReporteButton.Click += new System.EventHandler(this.verReporteButton_Click);
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1363, 672);
            this.Controls.Add(this.verReporteButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.todosCheckBox);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Listado de Productos---";
            this.Load += new System.EventHandler(this.frmListadoProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox todosCheckBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton productoRadioButton;
        private System.Windows.Forms.RadioButton codigoRadioButton;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private cryProductosListado cryProductosListado1;
        private System.Windows.Forms.Button verReporteButton;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private DSMiAppComercialTableAdapters.CategoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}