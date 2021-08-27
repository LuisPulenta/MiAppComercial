using CAD;
using System;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Maestros
{
    public partial class frmProveedores : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            this.tipoDocumentoTableAdapter.Fill(this.dSMiAppComercial.TipoDocumento);
            this.proveedorTableAdapter.Fill(this.dSMiAppComercial.Proveedor);
            dgvDatos.AutoResizeColumns();
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            proveedorBindingSource.AddNew();
            iDTipoDocumentoComboBox.Focus();
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

            //if (CADCompra.ProveedorTieneCompras(Convert.ToInt32(iDProveedorTextBox.Text)))
            //{
            //    MessageBox.Show(
            //        "No se puede borrar Proveedor porque tiene movimientos",
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}

            this.Validate();
            this.proveedorBindingSource.RemoveAt(proveedorBindingSource.Position);
            this.tableAdapterManager.UpdateAll(this.dSMiAppComercial);
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (!Validarcampos()) return;
            this.Validate();
            this.proveedorBindingSource.EndEdit();
            try
            {
                this.tableAdapterManager.UpdateAll(this.dSMiAppComercial);
                errorProvider1.Clear();
            }
            catch (Exception)
            {
                errorProvider1.SetError(documentoTextBox, "Este N° de Documento ya está asignado");
                documentoTextBox.Focus();
                return;
            }
            Habilitar(false);
            //VerificarPermisos();
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.proveedorBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
            //VerificarPermisos();
        }

        private void Habilitar(bool campo)
        {
            iDTipoDocumentoComboBox.Enabled = campo;
            documentoTextBox.ReadOnly = !campo;
            nombreTextBox.ReadOnly = !campo;
            nombreContactoTextBox.ReadOnly = !campo;
            apellidoContactoTextBox.ReadOnly = !campo;
            direccionTextBox.ReadOnly = !campo;
            telefonoTextBox.ReadOnly = !campo;
            celularTextBox.ReadOnly = !campo;
            correoTextBox.ReadOnly = !campo;
            notasTextBox.ReadOnly = !campo;

            bindingNavigatorEditItem.Enabled = !campo;
            bindingNavigatorAddNewItem.Enabled = !campo;
            bindingNavigatorDeleteItem.Enabled = !campo;
            bindingNavigatorSaveItem.Enabled = campo;
            bindingNavigatorCancelItem.Enabled = campo;
            bindingNavigatorSearchItem.Enabled = !campo;

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
            if (iDTipoDocumentoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDTipoDocumentoComboBox, "Debe seleccionar un Tipo de Documento");
                iDTipoDocumentoComboBox.Focus();
                return false;
            }

            if (documentoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(documentoTextBox, "Debe ingresar un N° de Documento");
                documentoTextBox.Focus();
                return false;
            }

            if (documentoTextBox.Text.Length > 20)
            {
                errorProvider1.SetError(documentoTextBox, "El Documento no puede tener más de 20 caracteres");
                documentoTextBox.Focus();
                return false;
            }

            if (nombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreTextBox, "Debe ingresar un Nombre de Proveedor");
                nombreTextBox.Focus();
                return false;
            }

            if (nombreTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(nombreTextBox, "El Nombre Comercial no puede tener más de 50 caracteres");
                nombreTextBox.Focus();
                return false;
            }

            if (nombreContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nombreContactoTextBox, "Debe ingresar un Nombre de Contacto");
                nombreContactoTextBox.Focus();
                return false;
            }

            if (nombreContactoTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(nombreContactoTextBox, "El Nombre Contacto no puede tener más de 50 caracteres");
                nombreContactoTextBox.Focus();
                return false;
            }

            if (apellidoContactoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(apellidoContactoTextBox, "Debe ingresar un Apellido de Contacto");
                apellidoContactoTextBox.Focus();
                return false;
            }

            if (apellidoContactoTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(apellidoContactoTextBox, "El Apellido Contacto no puede tener más de 50 caracteres");
                apellidoContactoTextBox.Focus();
                return false;
            }

            if (direccionTextBox.Text != string.Empty)
            {
                if (direccionTextBox.Text.Length > 100)
                {
                    errorProvider1.SetError(direccionTextBox, "La Dirección no puede tener más de 100 caracteres");
                    direccionTextBox.Focus();
                    return false;
                }
            }

            if (telefonoTextBox.Text != string.Empty)
            {
                if (telefonoTextBox.Text.Length > 20)
                {
                    errorProvider1.SetError(telefonoTextBox, "El Teléfono no puede tener más de 20 caracteres");
                    telefonoTextBox.Focus();
                    return false;
                }
            }

            if (celularTextBox.Text != string.Empty)
            {
                if (celularTextBox.Text.Length > 20)
                {
                    errorProvider1.SetError(celularTextBox, "El Celular no puede tener más de 20 caracteres");
                    celularTextBox.Focus();
                    return false;
                }
            }

            if (correoTextBox.Text != string.Empty)
            {
                RegexUtilities regexUtilities = new RegexUtilities();
                if (!regexUtilities.IsValidEmail(correoTextBox.Text))
                {
                    errorProvider1.SetError(correoTextBox, "Si ingresa un correo, éste debe ser válido");
                    correoTextBox.Focus();
                    return false;
                }

                if (correoTextBox.Text.Length > 100)
                {
                    errorProvider1.SetError(correoTextBox, "El Correo no puede tener más de 100 caracteres");
                    correoTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }

        private void bindingNavigatorSearchItem_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            int position = proveedorBindingSource.Find("IDProveedor", miBusqueda.IDElegido);
            proveedorBindingSource.Position = position;
        }
    }
}