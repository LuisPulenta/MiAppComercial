using CAD;
using System;
using System.Windows.Forms;

namespace Win.Maestros
{
    public partial class frmParametrosAlmacen : Form
    {
        private string codigo;

        public string Codigo
        {
            set { codigo = value; }
        }



        public frmParametrosAlmacen()
        {
            InitializeComponent();
        }

        private void frmParametrosAlmacen_Load(object sender, EventArgs e)
        {
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            toolTip1.SetToolTip(bodegaComboBox, "Seleccione un almacén");
            toolTip1.SetToolTip(minimoNumericUpDown, "Ingrese la Cantidad Mínima de Stock");
            toolTip1.SetToolTip(maximoNumericUpDown, "Ingrese la Cantidad Máxima de Stock");
            toolTip1.SetToolTip(diasReposicionNumericUpDown, "Ingrese la cantidad de días de reposición");
            toolTip1.SetToolTip(cantidadMinimaNumericUpDown, "Ingrese la Cantidad Mínima a reponer");
            bodegaComboBox.SelectedIndex = -1;
        }

        private void bodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bodegaComboBox.SelectedIndex == -1) return;

            CADAlmacenProducto miBodegaProducto = CADAlmacenProducto.AlmacenProductoGetAlmacenProductoByIDAlmacenAndCodigo((int)bodegaComboBox.SelectedValue, codigo);

            if (miBodegaProducto == null)
            {
                stockTextBox.Text = string.Empty;
                cantidadMinimaNumericUpDown.Value = 1;
                diasReposicionNumericUpDown.Value = 1;
                minimoNumericUpDown.Value = 1;
                maximoNumericUpDown.Value = 1;
                diasReposicionNumericUpDown.Value = 1;
                return;
            }
            stockTextBox.Text = miBodegaProducto.Stock.ToString();
            cantidadMinimaNumericUpDown.Value = (decimal)miBodegaProducto.Minimo;
            diasReposicionNumericUpDown.Value = miBodegaProducto.DiasReposicion;
            minimoNumericUpDown.Value = (decimal)miBodegaProducto.Minimo;
            maximoNumericUpDown.Value = (decimal)miBodegaProducto.Maximo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (bodegaComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(bodegaComboBox, "Debe seleccionar una Bodega");
                bodegaComboBox.Focus();
                return;
            }
            CADAlmacenProducto.AlmacenProductoUpdate((int)bodegaComboBox.SelectedValue, codigo, (float)minimoNumericUpDown.Value, (float)maximoNumericUpDown.Value, (int)diasReposicionNumericUpDown.Value, (float)cantidadMinimaNumericUpDown.Value);
            this.Close();

        }
    }
}