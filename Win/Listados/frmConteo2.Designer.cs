
namespace Win.Listados
{
    partial class frmConteo2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSMiAppComercial = new Win.DSMiAppComercial();
            this.inventarioDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDetalleTableAdapter = new Win.DSMiAppComercialTableAdapters.InventarioDetalleTableAdapter();
            this.inventarioDetalleTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDetalleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.inventarioDetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Win.Listados.rptConteo2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1139, 684);
            this.reportViewer1.TabIndex = 1;
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
            // inventarioDetalleBindingSource1
            // 
            this.inventarioDetalleBindingSource1.DataMember = "InventarioDetalle";
            this.inventarioDetalleBindingSource1.DataSource = this.dSMiAppComercial;
            // 
            // frmConteo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 684);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmConteo2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---Conteo 2---";
            this.Load += new System.EventHandler(this.frmConteo2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSMiAppComercial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDetalleBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSMiAppComercial dSMiAppComercial;
        private System.Windows.Forms.BindingSource inventarioDetalleBindingSource;
        private DSMiAppComercialTableAdapters.InventarioDetalleTableAdapter inventarioDetalleTableAdapter;
        private System.Windows.Forms.BindingSource inventarioDetalleTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource inventarioDetalleBindingSource1;
    }
}