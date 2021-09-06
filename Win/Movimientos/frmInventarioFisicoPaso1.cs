using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Movimientos
{
    public partial class frmInventarioFisicoPaso1 : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private List<ProductoAInventariar> misProductosAInventariar = new List<ProductoAInventariar>();

        public frmInventarioFisicoPaso1()
        {
            InitializeComponent();
        }

        private void frmInventarioFisicoPaso1_Load(object sender, EventArgs e)
        {
            this.categoriaTableAdapter.Fill(this.dSMiAppComercial.Categoria);
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            almacenComboBox.SelectedIndex = -1;
            categoriaComboBox.SelectedIndex = -1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                categoriaComboBox.Enabled = true;
            }
            else
            {
                categoriaComboBox.SelectedIndex = -1;
                categoriaComboBox.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                almacenComboBox.SelectedIndex = -1;
                almacenComboBox.Enabled = false;
            }
            else
            {
                almacenComboBox.Enabled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
            "¿Está seguro de programar el Inventario Físico?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            errorProvider1.Clear();
            if (almacenComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(almacenComboBox, "Debe seleccionar un Almacén");
                almacenComboBox.Focus();
                return;
            }
            if (radioButton2.Checked)
            {
                if (categoriaComboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(categoriaComboBox, "Debe seleccionar una Categoría");
                    categoriaComboBox.Focus();
                    return;
                }
            }

            DateTime fecha = fechaDateTimePicker.Value;
            int IDAlmacen = (int)almacenComboBox.SelectedValue;

            if (radioButton1.Checked)
            {
                CAD.DSMiAppComercial.ProductosAInventariarDataTable miTabla = CADProductosAInventariar.ProductosAInventariarByIDBodega((int)almacenComboBox.SelectedValue);
                foreach (CAD.DSMiAppComercial.ProductosAInventariarRow miRegistro in miTabla.Rows)
                {
                    ProductoAInventariar productoAInventariar = new ProductoAInventariar();
                    productoAInventariar.Codigo = miRegistro.Codigo;
                    productoAInventariar.Descripcion = miRegistro.Descripcion;
                    productoAInventariar.Saldo = (float)miRegistro.Saldo;
                    misProductosAInventariar.Add(productoAInventariar);
                }
            }
            else
            {
                CAD.DSMiAppComercial.ProductosAInventariarDataTable miTabla = CADProductosAInventariar.ProductosAInventariarByIDBodegaAndIDDepartamento((int)almacenComboBox.SelectedValue, (int)categoriaComboBox.SelectedValue);
                foreach (CAD.DSMiAppComercial.ProductosAInventariarRow miRegistro in miTabla.Rows)
                {
                    ProductoAInventariar productoAInventariar = new ProductoAInventariar();
                    productoAInventariar.Codigo = miRegistro.Codigo;
                    productoAInventariar.Descripcion = miRegistro.Descripcion;
                    productoAInventariar.Saldo = (float)miRegistro.Saldo;
                    misProductosAInventariar.Add(productoAInventariar);
                }
            }

            //Grabamos la Cabecera del Inventario

            int IDInventario = CADInventario.InventarioInsert(
                fecha,
                IDAlmacen);

            //Grabamos el Detalle del Inventario
            //Hay que obtener la lista de productos y guardarla en InventarioDetalle


            foreach (ProductoAInventariar miProductosAInventariar in misProductosAInventariar)
            {
                CADInventarioDetalle.InventarioDetalleInsert(
                    IDInventario,
                    miProductosAInventariar.Codigo,
                    miProductosAInventariar.Descripcion,
                    miProductosAInventariar.Saldo,
                    0,
                    0,
                    0,
                    0);
            }

            //Mensaje Final
            MessageBox.Show(
            string.Format("El Inventario Físico {0}, fue grabado de forma exitosa. Puede proceder a hacer los Conteos.", IDInventario),
            "Confirmación",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            this.Close();
        }
    }
}
