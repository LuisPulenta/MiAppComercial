
namespace Win
{
    partial class frmConteo1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConteo1));
            this.inventarioDetalleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.inventarioDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDetalleTableAdapter = new Win.DSMiAppComercialTableAdapters.InventarioDetalleTableAdapter();
            this.inventarioDetalleTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioDetalleBindingSource1
            // 
            this.inventarioDetalleBindingSource1.DataMember = "InventarioDetalle";
            this.inventarioDetalleBindingSource1.DataSource = this.dSMiAppComercial;
            // 
            // dSMiAppComercial
            // 
            this.dSMiAppComercial.DataSetName = "DSMiAppComercial";
            this.dSMiAppComercial.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioDetalleBindingSource
            // 
            this.inventarioDetalleBindingSource.DataMember = "InventarioDetalle";
            this.inventarioDetalleBindingSource.DataSource = this.dSMiAppComercial;
            // 
            // inventarioDetalleTableAdapter
            // 
            this.inventarioDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // inventarioDetalleTableAdapterBindingSource
            // 
            this.inventarioDetalleTableAdapterBindingSource.DataSource = typeof(Win.DSMiAppComercialTableAdapters.InventarioDetalleTableAdapter);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.inventarioDetalleBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Win.Listados.rptConteo1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1139, 684);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmConteo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 684);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConteo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Conteo 1---";
            this.Load += new System.EventHandler(this.frmConteo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource inventarioDetalleBindingSource;
        private DSMiAppComercial dSMiAppComercial;
        private DSMiAppComercialTableAdapters.InventarioDetalleTableAdapter inventarioDetalleTableAdapter;
        private System.Windows.Forms.BindingSource inventarioDetalleTableAdapterBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource inventarioDetalleBindingSource1;
    }
}