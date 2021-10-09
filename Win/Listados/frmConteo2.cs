using System;
using System.Windows.Forms;

namespace Win.Listados
{
    public partial class frmConteo2 : Form
    {
        private int _IdInventario;
        public int IdInventario { get => _IdInventario; set => _IdInventario = value; }

        public frmConteo2()
        {
            InitializeComponent();
        }

        private void frmConteo2_Load(object sender, EventArgs e)
        {
            try
            {
                this.inventarioDetalleTableAdapter.Fill2(this.dSMiAppComercial.InventarioDetalle, IdInventario);
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