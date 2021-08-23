using CAD;
using System;
using System.Windows.Forms;
using Win.Clases;

namespace Win
{
    public partial class frmAlmacenes : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmAlmacenes()
        {
            InitializeComponent();
        }

        private void almacenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            almacenBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dSMiAppComercial);

        }

        private void frmAlmacenes_Load(object sender, EventArgs e)
        {
            almacenTableAdapter.Fill(dSMiAppComercial.Almacen);
            dgvDatos.AutoResizeColumns();
            this.toolTip1.SetToolTip(this.descripcionTextBox, "Ingrese una descripción (máximo 50 caracteres).");
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            almacenBindingSource.AddNew();
            descripcionTextBox.Focus();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos())
            {
                return;
            }

            Validate();
            almacenBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dSMiAppComercial);
            Habilitar(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de borrar el Registro actual?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No)
            {
                return;
            }

            Validate();
            almacenBindingSource.RemoveAt(almacenBindingSource.Position);
            tableAdapterManager.UpdateAll(dSMiAppComercial);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            almacenBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        private void Habilitar(bool campo)
        {
            descripcionTextBox.ReadOnly = !campo;

            bindingNavigatorEditItem.Enabled = !campo;
            bindingNavigatorAddNewItem.Enabled = !campo;
            bindingNavigatorDeleteItem.Enabled = !campo;
            bindingNavigatorSaveItem.Enabled = campo;
            bindingNavigatorCancelItem.Enabled = campo;

            bindingNavigatorMoveFirstItem.Enabled = !campo;
            bindingNavigatorMovePreviousItem.Enabled = !campo;
            bindingNavigatorMoveNextItem.Enabled = !campo;
            bindingNavigatorMoveLastItem.Enabled = !campo;
            bindingNavigatorPositionItem.Enabled = !campo;
            bindingNavigatorCountItem.Enabled = !campo;
            dgvDatos.AutoResizeColumns();
        }

        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una  descripción para el Almacén");
                descripcionTextBox.Focus();
                return false;
            }

            if (descripcionTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(descripcionTextBox, "La descripción no puede tener más de 50 caracteres");
                descripcionTextBox.Focus();
                return false;
            }

            return true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }
    }
}
