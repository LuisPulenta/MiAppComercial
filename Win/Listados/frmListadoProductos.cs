using CAD;
using System;
using System.Windows.Forms;
using Win.DSMiAppComercialTableAdapters;

namespace Win.Listados
{
    public partial class frmListadoProductos : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void frmListadoProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.FillBy(this.dSMiAppComercial.Categoria);
            categoriaComboBox.SelectedIndex = -1;
            categoriaComboBox.Enabled = false;
        }

        private void verReporteButton_Click(object sender, EventArgs e)
        {
            cryProductosListado miReporte = new cryProductosListado();
            DSMiAppComercial miDS = new DSMiAppComercial();
            ProductosListadoTableAdapter miAdaptador = new ProductosListadoTableAdapter();
            errorProvider1.Clear();
            if (todosCheckBox.Checked && codigoRadioButton.Checked)
            {
                miAdaptador.FillAllOrderByCodigo(miDS.ProductosListado);
                categoriaComboBox.SelectedIndex = -1;
                categoriaComboBox.Enabled = false;
            }
            else if (todosCheckBox.Checked && productoRadioButton.Checked)
            {
                miAdaptador.FillAllOrderByProducto(miDS.ProductosListado);
                categoriaComboBox.SelectedIndex = -1;
                categoriaComboBox.Enabled = false;
            }
            else if (!todosCheckBox.Checked && codigoRadioButton.Checked)
            {
                categoriaComboBox.Enabled = true;
                if (categoriaComboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(categoriaComboBox, "Debe seleccionar una Categoría");
                    return;
                }
                miAdaptador.FillByCategoriaOrderByCodigo(miDS.ProductosListado, (int)categoriaComboBox.SelectedValue);
            }
            else if (!todosCheckBox.Checked && productoRadioButton.Checked)
            {
                categoriaComboBox.Enabled = true;
                if (categoriaComboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(categoriaComboBox, "Debe seleccionar una Categoría");
                    return;
                }
                miAdaptador.FillByCategoriaOrderByProducto(miDS.ProductosListado, (int)categoriaComboBox.SelectedValue);
            }
            miReporte.SetDataSource(miDS);
            crystalReportViewer1.ReportSource = miReporte;
        }

        private void todosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (todosCheckBox.Checked)
            {
                categoriaComboBox.Enabled = false;
            }
            else
            {
                categoriaComboBox.Enabled = true;
            }
        }
    }
}
