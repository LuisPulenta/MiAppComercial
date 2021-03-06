using CAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Movimientos
{
    public partial class frmConsultaKardex : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmConsultaKardex()
        {
            InitializeComponent();
        }

        private void frmConsultaKardex_Load(object sender, EventArgs e)
        {
            almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            almacenComboBox.SelectedIndex = -1;
            productoLabel.Text = string.Empty;
            hastaDateTimePicker.Value = DateTime.Now;
            desdeDateTimePicker.Value = DateTime.Now.AddDays(-30);
            dgvDatos.AutoResizeColumns();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == "") return;
            productoTextBox.Text = miBusqueda.IDElegido.ToString();
            productoTextBox_Validated(sender, new System.ComponentModel.CancelEventArgs());

        }

        private void productoTextBox_Validated(object sender, EventArgs e)
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

            CADProducto miProducto = CADProducto.ProductoGetProductoByCodigo(producto);
            if (miProducto == null)
            {
                miProducto = CADProducto.ProductoGetProductoByIDBarra(barra);
            }
            if (miProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Producto no existe");
                productoLabel.Text = string.Empty;
                pbxImagen.Image = null;
                return;
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
            }
            productoTextBox.Text = miProducto.Codigo;
            ActualizarDatos();

        }

        private void ActualizarDatos()
        {
            if (almacenComboBox.SelectedIndex == -1 || productoTextBox.Text == string.Empty) return;


            string diaDesde = desdeDateTimePicker.Value.Day.ToString();
            if (diaDesde.Length == 1)
            {
                diaDesde = '0' + diaDesde;
            }
            string mesDesde = desdeDateTimePicker.Value.Month.ToString();
            if (mesDesde.Length == 1)
            {
                mesDesde = '0' + mesDesde;
            }
            string anoDesde = desdeDateTimePicker.Value.Year.ToString();
            string fechaDesde = diaDesde + '-' + mesDesde + '-' + anoDesde;

            string diaHasta = hastaDateTimePicker.Value.AddDays(1).Day.ToString();
            if (diaHasta.Length == 1)
            {
                diaHasta = '0' + diaHasta;
            }
            string mesHasta = hastaDateTimePicker.Value.AddDays(1).Month.ToString();
            if (mesHasta.Length == 1)
            {
                mesHasta = '0' + mesHasta;
            }
            string anoHasta = hastaDateTimePicker.Value.AddDays(1).Year.ToString();
            string fechaHasta = diaHasta + '-' + mesHasta + '-' + anoHasta;

            this.kardexTableAdapter.FillBy(this.dSMiAppComercial.Kardex, ((int)(System.Convert.ChangeType(almacenComboBox.SelectedValue, typeof(int)))), (productoTextBox.Text), Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
            dgvDatos.AutoResizeColumns();
        }

        private void bodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void almacenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }

        private void desdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void hastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void resetDesdeButton_Click(object sender, EventArgs e)
        {
            desdeDateTimePicker.Value=DateTime.Now.AddDays(-30);
        }

        private void resetHastaButton_Click(object sender, EventArgs e)
        {
            hastaDateTimePicker.Value = DateTime.Now;
        }
    }
}
