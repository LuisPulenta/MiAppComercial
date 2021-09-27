using CAD;
using System;
using System.Windows.Forms;

namespace Win.Movimientos
{
    public partial class frmCancelarInventariosNoTerminados : Form
    {
        public frmCancelarInventariosNoTerminados()
        {
            InitializeComponent();
        }

        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private void frmCancelarInventariosNoTerminados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill4(this.dSMiAppComercial.Inventario);
            IDInventarioComboBox.SelectedIndex = -1;
            btnBorrar.Enabled = false;
        }

        private void IDInventarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
         "¿Está seguro de Borrar este Inventario?",
         "Confirmación",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question,
         MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No)
            {
                return;
            }

            CADInventarioDetalle.InventarioDetalleDelete((int) IDInventarioComboBox.SelectedValue);
            CADInventario.InventarioDelete((int)IDInventarioComboBox.SelectedValue);

            MessageBox.Show(
               string.Format("El Inventario {0} fue borrado con éxito.", (int)IDInventarioComboBox.SelectedValue),
               "Aviso!",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

            this.Close();
        }
    }
}
