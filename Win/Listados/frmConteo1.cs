using System;
using System.Windows.Forms;

namespace Win
{
    public partial class frmConteo1 : Form
    {
        private int _IdInventario;
        public int IdInventario { get => _IdInventario; set => _IdInventario = value; }

        public frmConteo1()
        {
            InitializeComponent();
        }

        private void frmConteo1_Load(object sender, EventArgs e)
        {

            try
            {
                this.inventarioDetalleTableAdapter.Fill(this.dSMiAppComercial.InventarioDetalle, IdInventario);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
