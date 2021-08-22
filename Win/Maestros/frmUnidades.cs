using CAD;
using System;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Maestros
{
    public partial class frmUnidades : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmUnidades()
        {
            InitializeComponent();
        }

        private void unidadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            unidadBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dSMiAppComercial);

        }

        private void frmUnidades_Load(object sender, EventArgs e)
        {
            unidadTableAdapter.Fill(dSMiAppComercial.Unidad);
            dgvDatos.AutoResizeColumns();
            toolTip1.SetToolTip(descripcionTextBox, "Ingrese una descripción (máximo 20 caracteres)");
            toolTip1.SetToolTip(iDUnidadTextBox, "Ingrese una Unidad (máximo 3 caracteres)");
        }

        private void Habilitar(bool campo)
        {
            iDUnidadTextBox.ReadOnly = !campo;
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

            if (iDUnidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(iDUnidadTextBox, "Debe ingresar una Unidad");
                iDUnidadTextBox.Focus();
                return false;
            }

            if (iDUnidadTextBox.Text.Length > 3)
            {
                errorProvider1.SetError(iDUnidadTextBox, "La Unidad debe ser de no más de 3 caracteres");
                iDUnidadTextBox.Focus();
                return false;
            }

            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una  descripción para la Unidad de Medida");
                descripcionTextBox.Focus();
                return false;
            }

            if (descripcionTextBox.Text.Length>20)
            {
                errorProvider1.SetError(descripcionTextBox, "La descripción no puede tener más de 20 caracteres");
                descripcionTextBox.Focus();
                return false;
            }

            return true;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            unidadBindingSource.AddNew();
            iDUnidadTextBox.Focus();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            iDUnidadTextBox.Text = iDUnidadTextBox.Text.ToUpper();
            try
            {
                iDUnidadTextBox.Text = iDUnidadTextBox.Text.ToUpper();
                if (!Validarcampos())
                {
                    return;
                }

                Validate();
                unidadBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dSMiAppComercial);
                Habilitar(false);
            }
            catch (Exception)
            {
                errorProvider1.SetError(iDUnidadTextBox, "Este Unidad ya existe");
                iDUnidadTextBox.Focus();
            }
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

            try
            {
                Validate();
                unidadBindingSource.RemoveAt(unidadBindingSource.Position);
                tableAdapterManager.UpdateAll(dSMiAppComercial);
            }
            catch (Exception)
            {
                MessageBox.Show("Esta Unidad no se puede eliminar porque tiene Registros Relacionados", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                unidadTableAdapter.Fill(dSMiAppComercial.Unidad);
            }
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            unidadBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }
    }
}
