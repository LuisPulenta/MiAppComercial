
namespace Win.Movimientos
{
    partial class frmCancelarInventariosNoTerminados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCancelarInventariosNoTerminados));
            this.IDInventarioComboBox = new System.Windows.Forms.ComboBox();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.inventarioTableAdapter = new Win.DSMiAppComercialTableAdapters.InventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            this.SuspendLayout();
            // 
            // IDInventarioComboBox
            // 
            this.IDInventarioComboBox.DataSource = this.inventarioBindingSource;
            this.IDInventarioComboBox.DisplayMember = "Inventario";
            this.IDInventarioComboBox.FormattingEnabled = true;
            this.IDInventarioComboBox.Location = new System.Drawing.Point(133, 35);
            this.IDInventarioComboBox.Name = "IDInventarioComboBox";
            this.IDInventarioComboBox.Size = new System.Drawing.Size(569, 24);
            this.IDInventarioComboBox.TabIndex = 28;
            this.IDInventarioComboBox.ValueMember = "IDInventario";
            this.IDInventarioComboBox.SelectedIndexChanged += new System.EventHandler(this.IDInventarioComboBox_SelectedIndexChanged);
            // 
            // inventarioBindingSource
            // 
            this.inventarioBindingSource.DataMember = "Inventario";
            this.inventarioBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // dSMiAppComercial
            // 
            this.dSMiAppComercial.DataSetName = "DSMiAppComercial";
            this.dSMiAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Inventario:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(285, 104);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(193, 54);
            this.btnBorrar.TabIndex = 29;
            this.btnBorrar.Text = "Borrar Inventario";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmCancelarInventariosNoTerminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 206);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.IDInventarioComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCancelarInventariosNoTerminados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Cancelar Inventarios No Terminados---";
            this.Load += new System.EventHandler(this.frmCancelarInventariosNoTerminados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox IDInventarioComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private DSMiAppComercialTableAdapters.InventarioTableAdapter inventarioTableAdapter;
    }
}