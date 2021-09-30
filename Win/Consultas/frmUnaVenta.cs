using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmUnaVenta : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int iDVenta;
        public int IDVenta

        {
            get => iDVenta;
            set => iDVenta = value;
        }

        private DateTime fecha;
        public DateTime Fecha

        {
            get => fecha;
            set => fecha = value;
        }

        private string cliente;
        public string Cliente

        {
            get => cliente;
            set => cliente = value;
        }

        private string almacen;
        public string Almacen

        {
            get => almacen;
            set => almacen = value;
        }

        private List<DetalleVenta> misDetalles = new List<DetalleVenta>();

        private int totalItems = 0;
        private decimal totalBruto = 0;
        private decimal totalIVA = 0;
        private decimal totalDescuento = 0;
        private decimal totalNeto = 0;

        public frmUnaVenta()
        {
            InitializeComponent();
        }

        private void frmUnaVenta_Load(object sender, EventArgs e)
        {
            iDVentaTextBox.Text = IDVenta.ToString();
            fechaTextBox.Text = Fecha.ToString();
            clienteTextBox.Text = Cliente;
            almacenTextBox.Text = Almacen;
            iDVentaTextBox_Validating(sender, e);
        }

        private void iDVentaTextBox_Validating(object sender, EventArgs e)
        {
            fechaTextBox.Text = string.Empty;
            clienteTextBox.Text = string.Empty;
            almacenTextBox.Text = string.Empty;
            misDetalles.Clear();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;
            PersonalizarGrilla();

            if (iDVentaTextBox.Text == null) return;
            CADVenta miVenta = CADVenta.VentasGetVentaByIDVenta(Convert.ToInt32(iDVentaTextBox.Text));
            if (miVenta == null)
            {
               
                errorProvider1.SetError(iDVentaTextBox, "No existe esta Venta");
                iDVentaTextBox.Focus();
                return;
            }

            fechaTextBox.Text = miVenta.Fecha.ToString();
            clienteTextBox.Text = Cliente;
            almacenTextBox.Text = Almacen;

            CAD.DSMiAppComercial.VentaDetalleDataTable miTabla = CADVentaDetalle.VentaDetalleGetVentaDetalleByIDVenta(miVenta.IDVenta);
            foreach (CAD.DSMiAppComercial.VentaDetalleRow miRegistro in miTabla.Rows)
            {
                DetalleVenta miDetalle = new DetalleVenta();
                miDetalle.Cantidad = (float)miRegistro.Cantidad;
                miDetalle.Codigo = miRegistro.Codigo;
                miDetalle.Precio = miRegistro.Precio;
                miDetalle.Descripcion = miRegistro.Descripcion;
                miDetalle.PorcentajeDescuento = (float)miRegistro.PorcentajeDescuento;
                miDetalle.PorcentajeIVA = (float)miRegistro.PorcentajeIVA;

                misDetalles.Add(miDetalle);
            }
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;
            PersonalizarGrilla();
            dgvDatos.AutoResizeColumns();
        }

        private void PersonalizarGrilla()
        {
            dgvDatos.Columns["Codigo"].HeaderText = "Código";
            dgvDatos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatos.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatos.Columns["Precio"].HeaderText = "Precio";
            dgvDatos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Precio"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            dgvDatos.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";

            dgvDatos.Columns["PorcentajeDescuento"].HeaderText = "% Descuento";
            dgvDatos.Columns["PorcentajeDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["PorcentajeDescuento"].DefaultCellStyle.Format = "P2";

            dgvDatos.Columns["valorBruto"].HeaderText = "Valor Bruto";
            dgvDatos.Columns["valorBruto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorBruto"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["valorIVA"].HeaderText = "Valor IVA";
            dgvDatos.Columns["valorIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorIVA"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["valorDescuento"].HeaderText = "Valor Descuento";
            dgvDatos.Columns["valorDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorDescuento"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["valorNeto"].HeaderText = "Valor Neto";
            dgvDatos.Columns["valorNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorNeto"].DefaultCellStyle.Format = "C2";

            totalItems = 0;
            totalBruto = 0;
            totalIVA = 0;
            totalDescuento = 0;
            totalNeto = 0;

            foreach (DetalleVenta miDetalle in misDetalles)
            {
                totalItems += 1;
                totalBruto += miDetalle.valorBruto;
                totalIVA += miDetalle.valorIVA;
                totalDescuento += miDetalle.valorDescuento;
                totalNeto += miDetalle.valorNeto;
            }

            totalItemTextBox.Text = string.Format("{0:N0}", totalItems);
            totalBrutoTextBox.Text = string.Format("{0:C2}", totalBruto);
            totalIVATextBox.Text = string.Format("{0:C2}", totalIVA);
            totalDescuentoTextBox.Text = string.Format("{0:C2}", totalDescuento);
            totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            frmBusquedaVentas miBusqueda = new frmBusquedaVentas();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            iDVentaTextBox.Text = miBusqueda.IDElegido.ToString();
            iDVentaTextBox.Focus();
            iDVentaTextBox_Validating(sender, e);
        }

        private void iDVentaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                iDVentaTextBox_Validating(sender, e);
        }
    }
}
