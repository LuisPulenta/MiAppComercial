using CAD;
using System;
using System.Linq;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Maestros
{
    public partial class frmUsuarios : Form
    {
        private bool nuevo = false;

        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
         
            this.usuarioTableAdapter.Fill(this.dSMiAppComercial.Usuario);
            this.rolTableAdapter.Fill(this.dSMiAppComercial.Rol);

            confirmacionTextBox.Text = claveTextBox.Text;
            dgvDatos.AutoResizeColumns();
            this.toolTip1.SetToolTip(this.iDUsuarioTextBox, "Ingrese Usuario, debe tener entre 6 y 12 caracteres.");
            this.toolTip1.SetToolTip(this.iDRolComboBox, "Seleccione un Rol.");
            this.toolTip1.SetToolTip(this.nombreTextBox, "Ingrese Nombre (máximo 30 caracteres).");
            this.toolTip1.SetToolTip(this.apellidoTextBox, "Ingrese Apellido (máximo 30 caracteres).");
            this.toolTip1.SetToolTip(this.claveTextBox, "Ingrese Clave, debe tener entre 8 y 20 caracteres y contener al menos una mayúscula, una minúscula y un número.");
            this.toolTip1.SetToolTip(this.confirmacionTextBox, "Repita la Clave.");
            this.toolTip1.SetToolTip(this.correoTextBox, "Ingrese un Correo válido (máximo 100 caracteres).");
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            iDUsuarioTextBox.ReadOnly = true;
            nuevo = false;
            iDRolComboBox.Focus();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
            iDUsuarioTextBox.ReadOnly = false;
            confirmacionTextBox.Clear();
            //iDRolComboBox.SelectedIndex = -1;
            fechaModificacionClaveDateTimePicker.Value = DateTime.Now;
            usuarioBindingSource.AddNew();
            iDUsuarioTextBox.Focus();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            fechaModificacionClaveDateTimePicker.Value = DateTime.Now;
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dSMiAppComercial);
            Habilitar(false);
            dgvDatos.AutoResizeColumns();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de borrar el Registro actual?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            this.Validate();
            this.usuarioBindingSource.RemoveAt(usuarioBindingSource.Position);
            this.tableAdapterManager1.UpdateAll(this.dSMiAppComercial);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            confirmacionTextBox.Text = claveTextBox.Text;
            this.usuarioBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
        }

        private void Habilitar(bool campo)
        {
            iDUsuarioTextBox.ReadOnly = false;
            iDRolComboBox.Enabled = campo;
            nombreTextBox.ReadOnly = !campo;
            apellidoTextBox.ReadOnly = !campo;
            claveTextBox.ReadOnly = !campo;
            confirmacionTextBox.ReadOnly = !campo;
            correoTextBox.ReadOnly = !campo;

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
        }

        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (nuevo)
            {
                if (iDUsuarioTextBox.Text == string.Empty)
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "Debe ingresar un IDUsuario");
                    iDUsuarioTextBox.Focus();
                    return false;
                }

                if (iDUsuarioTextBox.Text.Length <6)
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "El IDUsuario debe ser de al menos 6 caracteres");
                    iDUsuarioTextBox.Focus();
                    return false;
                }

                if (iDUsuarioTextBox.Text.Length >12)
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "El IDUsuario no puede tener más de 12 caracteres");
                    iDUsuarioTextBox.Focus();
                    return false;
                }

                if (CADUsuario.UsuarioExiste(iDUsuarioTextBox.Text))
                {
                    errorProvider1.SetError(iDUsuarioTextBox, "Este IDUsuario ya existe");
                    iDUsuarioTextBox.Focus();
                    return false;
                }
            }

            if (iDRolComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDRolComboBox, "Debe seleccionar un Rol");
                iDRolComboBox.Focus();
                return false;
            }

            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un Nombre");
                nombreTextBox.Focus();
                return false;
            }

            if (nombreTextBox.Text.Length > 30)
            {
                errorProvider1.SetError(nombreTextBox, "El nombre no puede tener más de 30 caracteres");
                nombreTextBox.Focus();
                return false;
            }

            if (apellidoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidoTextBox, "Debe ingresar un Apellido");
                apellidoTextBox.Focus();
                return false;
            }

            if (apellidoTextBox.Text.Length > 30)
            {
                errorProvider1.SetError(apellidoTextBox, "El apellido no puede tener más de 30 caracteres");
                apellidoTextBox.Focus();
                return false;
            }

            if (claveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(claveTextBox, "Debe ingresar una Clave");
                claveTextBox.Focus();
                return false;
            }

            if (claveTextBox.Text.Length < 8)
            {
                errorProvider1.SetError(claveTextBox, "La Clave debe ser de al menos 8 caracteres");
                claveTextBox.Focus();
                return false;
            }

            if (claveTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(claveTextBox, "La Clave no puede tener más de 20 caracteres");
                claveTextBox.Focus();
                return false;
            }

            if (!claveTextBox.Text.Any(c => char.IsUpper(c)))
            {
                errorProvider1.SetError(claveTextBox, "La Clave debe contener al menos una letra mayúscula");
                claveTextBox.Focus();
                return false;
            }

            if (!claveTextBox.Text.Any(c => char.IsLower(c)))
            {
                errorProvider1.SetError(claveTextBox, "La Clave debe contener al menos una letra minúscula");
                claveTextBox.Focus();
                return false;
            }

            if (!claveTextBox.Text.Any(c => char.IsDigit(c)))
            {
                errorProvider1.SetError(claveTextBox, "La Clave debe contener al menos un número");
                claveTextBox.Focus();
                return false;
            }

            if (confirmacionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(confirmacionTextBox, "Debe ingresar una Confirmación de Clave");
                confirmacionTextBox.Focus();
                return false;
            }

            if (claveTextBox.Text != confirmacionTextBox.Text)
            {
                errorProvider1.SetError(claveTextBox, "La Clave y su Confirmación no son iguales");
                errorProvider1.SetError(confirmacionTextBox, "La Clave y su Confirmación no son iguales");
                claveTextBox.Focus();
                return false;
            }

            if (correoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(correoTextBox, "Debe ingresar un Correo");
                correoTextBox.Focus();
                return false;
            }

            if (correoTextBox.Text.Length > 100)
            {
                errorProvider1.SetError(correoTextBox, "El correo no puede tener más de 100 caracteres");
                correoTextBox.Focus();
                return false;
            }

            RegexUtilities regexUtilities = new RegexUtilities();
            if (!regexUtilities.IsValidEmail(correoTextBox.Text))
            {
                errorProvider1.SetError(correoTextBox, "El correo ingresado no es válido");
                correoTextBox.Focus();
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
