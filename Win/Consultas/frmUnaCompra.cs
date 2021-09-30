using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmUnaCompra : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int iDCompra;
        public int IDCompra

        {
            get => iDCompra;
            set => iDCompra = value;
        }

        private DateTime fecha;
        public DateTime Fecha

        {
            get => fecha;
            set => fecha = value;
        }

        private string proveedor;
        public string Proveedor

        {
            get => proveedor;
            set => proveedor = value;
        }

        private string almacen;
        public string Almacen

        {
            get => almacen;
            set => almacen = value;
        }

        private List<DetalleCompra> misDetalles = new List<DetalleCompra>();

        private int totalItems = 0;
        private decimal totalBruto = 0;
        private decimal totalIVA = 0;
        private decimal totalDescuento = 0;
        private decimal totalNeto = 0;

        public frmUnaCompra()
        {
            InitializeComponent();
        }

        private void frmUnaCompra_Load(object sender, EventArgs e)
        {
            iDCompraTextBox.Text = IDCompra.ToString();
            fechaTextBox.Text = Fecha.ToString();
            proveedorTextBox.Text = Proveedor;
            almacenTextBox.Text = Almacen;
            iDCompraTextBox_Validating(sender, e);
        }

        private void iDCompraTextBox_Validating(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            fechaTextBox.Text = string.Empty;
            proveedorTextBox.Text = string.Empty;
            almacenTextBox.Text = string.Empty;
            misDetalles.Clear();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;
            PersonalizarGrilla();

            if (iDCompraTextBox.Text == null) return;

            CADCompra miCompra = CADCompra.ComprasGetCompraByIDCompra(Convert.ToInt32(iDCompraTextBox.Text));
            
            if (miCompra == null)
            {
                errorProvider1.SetError(iDCompraTextBox, "No existe esta Compra");
                iDCompraTextBox.Focus();
                return;
            }

            fechaTextBox.Text = miCompra.Fecha.ToString();
            proveedorTextBox.Text = Proveedor;
            almacenTextBox.Text = Almacen;

            CAD.DSMiAppComercial.CompraDetalleDataTable miTabla = CADCompraDetalle.CompraDetalleGetCompraDetalleByIDCompra(miCompra.IDCompra);
            foreach (CAD.DSMiAppComercial.CompraDetalleRow miRegistro in miTabla.Rows)
            {
                DetalleCompra miDetalle = new DetalleCompra();
                miDetalle.Cantidad = (float)miRegistro.Cantidad;
                miDetalle.Codigo = miRegistro.Codigo;
                miDetalle.Costo = miRegistro.Costo;
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

            dgvDatos.Columns["Costo"].HeaderText = "Costo";
            dgvDatos.Columns["Costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Costo"].DefaultCellStyle.Format = "C2";

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

            foreach (DetalleCompra miDetalle in misDetalles)
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

        private void iDCompraTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            iDCompraTextBox_Validating(sender, e);
        }

        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            frmBusquedaCompras miBusqueda = new frmBusquedaCompras();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            iDCompraTextBox.Text = miBusqueda.IDElegido.ToString();
            iDCompraTextBox_Validating(sender, e);
        }
    }
}