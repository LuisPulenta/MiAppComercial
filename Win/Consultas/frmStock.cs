using CAD;
using System;
using System.IO;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmStock : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private decimal totalCostoPromedio = 0;
        private decimal totalUltimoCosto = 0;

        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.FillBy(this.dSMiAppComercial.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            almacenesCheckBox.Checked = true;
            categoriasCheckBox.Checked = true;
            productosCheckBox.Checked = true;
            almacenComboBox.SelectedIndex = -1;
            almacenComboBox.Enabled = false;
            categoriaComboBox.SelectedIndex = -1;
            categoriaComboBox.Enabled = false;
            productoTextBox.Text=string.Empty;
            productoTextBox.Enabled = false;
            productoLabel.Text = string.Empty;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == "") return;
            productoTextBox.Text = miBusqueda.IDElegido.ToString();
            productoTextBox_Validating(sender, new System.ComponentModel.CancelEventArgs());
        }

        private void productoTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.Clear();
            pbxImagen.Image = null;
            if (productoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Código de Producto o un Código de Barras");
                return;
            }

            string producto = productoTextBox.Text;

            long barra;

            try
            {
                long.TryParse(productoTextBox.Text, out barra);
            }
            catch (Exception)
            {
                barra = 0;
            }

            CADProducto miProducto = CADProducto.ProductoGetProductoByCodigo((string)producto);
            if (miProducto == null)
            {
                miProducto = CADProducto.ProductoGetProductoByIDBarra(barra);
            }
            if (miProducto == null)
            {
                this.stockTableAdapter.FillBorrar(this.dSMiAppComercial.Stock);
                LlenarGrilla();
                errorProvider1.SetError(productoTextBox, "Producto no existe");
                productoLabel.Text = string.Empty;
                pbxImagen.Image = null;
            }
            else
            {
                productoLabel.Text = miProducto.Descripcion;
                if (miProducto.Imagen == string.Empty)
                {
                    pbxImagen.Image = null;
                }
                else
                {

                    if (File.Exists("Images\\" + miProducto.Imagen))
                    {
                        if (miProducto.Imagen == string.Empty)
                        {
                            pbxImagen.Image = null;
                        }
                        else
                        {
                            if (File.Exists("Images\\" + miProducto.Imagen))
                            {
                                pbxImagen.Load("Images\\" + miProducto.Imagen);
                            }
                        }
                    }
                    else
                    {
                        pbxImagen.Image = null;
                    }
                }
                LlenarGrilla();
            }
        }

        private void almacenesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (almacenesCheckBox.Checked)
            {
                almacenComboBox.SelectedIndex = -1;
                almacenComboBox.Enabled = false;
            }
            else
            {
                almacenComboBox.Enabled = true;
            }
            LlenarGrilla();
        }

        private void categoriasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (categoriasCheckBox.Checked)
            {
                categoriaComboBox.SelectedIndex = -1;
                categoriaComboBox.Enabled = false;
            }
            else
            {
                categoriaComboBox.Enabled = true;
            }
            LlenarGrilla();
        }

        private void productosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (productosCheckBox.Checked)
            {
                productoTextBox.Text = string.Empty;
                productoTextBox.Enabled = false;
            }
            else
            {
                productoTextBox.Enabled = true;
            }
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            totalCostoPromedio = 0;
            totalUltimoCosto = 0;
            this.stockTableAdapter.FillBorrar(this.dSMiAppComercial.Stock);

            if (almacenesCheckBox.Checked && categoriasCheckBox.Checked && productosCheckBox.Checked)
            {
                this.stockTableAdapter.Fill(this.dSMiAppComercial.Stock);
                dgvDatos.AutoResizeColumns();
            }

            if (!almacenesCheckBox.Checked && almacenComboBox.SelectedIndex >= 0 && categoriasCheckBox.Checked && productosCheckBox.Checked)
            {
                this.stockTableAdapter.FillByIDAlmacen(this.dSMiAppComercial.Stock,(int)almacenComboBox.SelectedValue);
                dgvDatos.AutoResizeColumns();
            }

            if (almacenesCheckBox.Checked && !categoriasCheckBox.Checked && categoriaComboBox.SelectedIndex >= 0 && productosCheckBox.Checked)
            {
                this.stockTableAdapter.FillByIDCategoria(this.dSMiAppComercial.Stock, (int)categoriaComboBox.SelectedValue);
                dgvDatos.AutoResizeColumns();
            }

            if (almacenesCheckBox.Checked && categoriasCheckBox.Checked && !productosCheckBox.Checked && productoTextBox.Text!=string.Empty)
            {
                this.stockTableAdapter.FillByIDCodigo(this.dSMiAppComercial.Stock, productoTextBox.Text);
                dgvDatos.AutoResizeColumns();
            }

            if (almacenesCheckBox.Checked && !categoriasCheckBox.Checked && categoriaComboBox.SelectedIndex >= 0 && !productosCheckBox.Checked && productoTextBox.Text != string.Empty)
            {
                this.stockTableAdapter.FillByIDCategoriaAndIDCodigo(this.dSMiAppComercial.Stock, (int)categoriaComboBox.SelectedValue,productoTextBox.Text);
                dgvDatos.AutoResizeColumns();
            }

            if (!almacenesCheckBox.Checked && almacenComboBox.SelectedIndex >= 0 && categoriasCheckBox.Checked && !productosCheckBox.Checked && productoTextBox.Text != string.Empty)
            {
                this.stockTableAdapter.FillByIDAlmacenAndIDCodigo(this.dSMiAppComercial.Stock, (int)almacenComboBox.SelectedValue, productoTextBox.Text);
                dgvDatos.AutoResizeColumns();
            }

            if (!almacenesCheckBox.Checked && almacenComboBox.SelectedIndex >= 0 && !categoriasCheckBox.Checked && categoriaComboBox.SelectedIndex >= 0 && productosCheckBox.Checked)
            {
                this.stockTableAdapter.FillByIDAlmacenAndIDCategoria(this.dSMiAppComercial.Stock, (int)almacenComboBox.SelectedValue, (int)categoriaComboBox.SelectedValue);
                dgvDatos.AutoResizeColumns();
            }

            if (!almacenesCheckBox.Checked && almacenComboBox.SelectedIndex >= 0 && !categoriasCheckBox.Checked && categoriaComboBox.SelectedIndex >= 0 && !productosCheckBox.Checked && productoTextBox.Text != string.Empty)
            {
                this.stockTableAdapter.FillByIDAlmacenAndIDCategoriaAndIDCodigo(this.dSMiAppComercial.Stock, (int)almacenComboBox.SelectedValue, (int)categoriaComboBox.SelectedValue, productoTextBox.Text);
                dgvDatos.AutoResizeColumns();
            }



            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                totalUltimoCosto = totalUltimoCosto + Convert.ToDecimal(row.Cells[9].Value);
                totalCostoPromedio = totalCostoPromedio + Convert.ToDecimal(row.Cells[10].Value);
                totalCostoPromedioTextBox.Text = string.Format("{0:C2}", totalCostoPromedio);
                totalUltimoCostoTextBox.Text = string.Format("{0:C2}", totalUltimoCosto);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }

        private void almacenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void productoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                productoTextBox_Validating(sender, new System.ComponentModel.CancelEventArgs());
        }
    }
}