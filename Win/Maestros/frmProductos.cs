using CAD;
using System;
using System.IO;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Maestros
{
    public partial class frmProductos : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.codigoTextBox, "Ingrese un Código de Producto.");
            toolTip1.SetToolTip(this.iDCategoriaComboBox, "Seleccione una Categoría.");
            toolTip1.SetToolTip(this.descripcionTextBox, "Ingrese una Descripción de Producto.");
            toolTip1.SetToolTip(this.iDUnidadComboBox, "Seleccione una Unidad.");
            toolTip1.SetToolTip(this.medidaTextBox, "Ingrese una Medida.");
            toolTip1.SetToolTip(this.iDIVAComboBox, "Seleccione un IVA.");
            toolTip1.SetToolTip(this.precioTextBox, "Ingrese un Precio.");
            toolTip1.SetToolTip(this.notasTextBox, "Ingrese Notas.");
            toolTip1.SetToolTip(this.imagenTextBox, "Ruta del archivo de imagen.");


            almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            almacenProductoTableAdapter.FillBy(dSMiAppComercial.AlmacenProducto, codigoTextBox.Text);
            barraTableAdapter.FillBy(dSMiAppComercial.Barra, codigoTextBox.Text);
            unidadTableAdapter.Fill(dSMiAppComercial.Unidad);
            iVATableAdapter.Fill(dSMiAppComercial.IVA);
            categoriaTableAdapter.FillBy(this.dSMiAppComercial.Categoria);
            productoTableAdapter.Fill(dSMiAppComercial.Producto);
            LlenarGrillas();
            CargarImagen();

            dgvDatos.AutoResizeColumns();
            barrasDataGridView.AutoResizeColumns();
            almacenesDataGridView.AutoResizeColumns();
        }

        private void Habilitar(bool campo)
        {
            descripcionTextBox.ReadOnly = !campo;
            iDCategoriaComboBox.Enabled = campo;
            precioTextBox.ReadOnly = !campo;
            iDIVAComboBox.Enabled = campo;
            btnBuscarImagen.Enabled = campo;
            notasTextBox.ReadOnly = !campo;
            iDUnidadComboBox.Enabled = campo;
            medidaTextBox.ReadOnly = !campo;
            btnAgregarBarra.Enabled = campo;
            btnEliminarBarra.Enabled = campo;
            btnAgregarBodega.Enabled = campo;

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
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            Habilitar(true);
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            productoBindingSource.CancelEdit();
            errorProvider1.Clear();
            Habilitar(false);
            codigoTextBox.ReadOnly = true;
        }

        private bool Validarcampos()
        {
            errorProvider1.Clear();

            if (codigoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(codigoTextBox, "Debe ingresar un Código");
                codigoTextBox.Focus();
                return false;
            }

            if (codigoTextBox.Text.Length > 12)
            {
                errorProvider1.SetError(codigoTextBox, "El Código no puede tener más de 12 caracteres");
                codigoTextBox.Focus();
                return false;
            }

            if (iDCategoriaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDCategoriaComboBox, "Debe seleccionar una Categoría");
                iDCategoriaComboBox.Focus();
                return false;
            }

            if (descripcionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(descripcionTextBox, "Debe ingresar una Descripción");
                descripcionTextBox.Focus();
                return false;
            }

            if (descripcionTextBox.Text.Length > 50)
            {
                errorProvider1.SetError(descripcionTextBox, "La descripción no puede tener más de 50 caracteres");
                descripcionTextBox.Focus();
                return false;
            }

            if (iDUnidadComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDUnidadComboBox, "Debe seleccionar una Unidad");
                iDUnidadComboBox.Focus();
                return false;
            }

            if (medidaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar una Medida");
                medidaTextBox.Focus();
                return false;
            }

            if (!float.TryParse(medidaTextBox.Text, out float medida))
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar un valor numérico");
                medidaTextBox.Focus();
                return false;
            }

            if (medida <= 0)
            {
                errorProvider1.SetError(medidaTextBox, "Debe ingresar un valor mayor a 0");
                medidaTextBox.Focus();
                return false;
            }

            if (iDIVAComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(iDIVAComboBox, "Debe seleccionar un IVA");
                iDIVAComboBox.Focus();
                return false;
            }

            if (precioTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un Precio");
                precioTextBox.Focus();
                return false;
            }

            if (!decimal.TryParse(precioTextBox.Text, out decimal precio))
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un valor numérico");
                precioTextBox.Focus();
                return false;
            }

            if (precio <= 0)
            {
                errorProvider1.SetError(precioTextBox, "Debe ingresar un valor mayor a 0");
                precioTextBox.Focus();
                return false;
            }

            errorProvider1.Clear();
            return true;
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validarcampos())
                {
                    return;
                }

                Validate();
                productoBindingSource.EndEdit();
                tableAdapterManager.UpdateAll(dSMiAppComercial);
                Habilitar(false);
                codigoTextBox.ReadOnly = true;
            }
            catch (Exception)
            {
                errorProvider1.SetError(codigoTextBox, "Este Codigo ya existe");
                codigoTextBox.Focus();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            codigoTextBox.ReadOnly = false;
            Habilitar(true);
            productoBindingSource.AddNew();
            codigoTextBox.Focus();
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
            productoBindingSource.RemoveAt(productoBindingSource.Position);
            tableAdapterManager.UpdateAll(dSMiAppComercial);
        }

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imagenTextBox.Text = openFileDialog1.FileName;
            CargarImagen();
        }

        private void CargarImagen()
        {
            if (imagenTextBox.Text == string.Empty)
            {
                pbxImagen.Image = null;
            }
            else
            {
                if (File.Exists(imagenTextBox.Text))
                {
                    pbxImagen.Load(imagenTextBox.Text);
                }
            }
        }

        private void LlenarGrillas()
        {
            barraTableAdapter.FillBy(dSMiAppComercial.Barra, codigoTextBox.Text);
            almacenProductoTableAdapter.FillBy(dSMiAppComercial.AlmacenProducto, codigoTextBox.Text);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
            CargarImagen();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
            CargarImagen();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
            CargarImagen();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            LlenarGrillas();
            CargarImagen();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarGrillas();
            CargarImagen();
        }

        private void btnAgregarBarra_Click(object sender, EventArgs e)
        {
            frmBarras miForm = new frmBarras();
            miForm.ShowDialog();
            if (miForm.Barra == 0)
            {
                return;
            }

            CADBarra.BarraInsert(codigoTextBox.Text, miForm.Barra);
            barraTableAdapter.FillBy(dSMiAppComercial.Barra, codigoTextBox.Text);
        }

        private void btnEliminarBarra_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de borrar el Código de Barras?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (rta == DialogResult.No)
            {
                return;
            }

            long barra = (long)barrasDataGridView.Rows[barraBindingSource.Position].Cells[0].Value;
            CADBarra.BarraDelete(barra);
            barraTableAdapter.FillBy(dSMiAppComercial.Barra, codigoTextBox.Text);
        }

        private void btnAgregarBodega_Click(object sender, EventArgs e)
        {
            frmParametrosAlmacen miForm = new frmParametrosAlmacen();
            miForm.Codigo = codigoTextBox.Text;
            miForm.ShowDialog();
            this.almacenProductoTableAdapter.FillBy(this.dSMiAppComercial.AlmacenProducto, codigoTextBox.Text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }
    }
}