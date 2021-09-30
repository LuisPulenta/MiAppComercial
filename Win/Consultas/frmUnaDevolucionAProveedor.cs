using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmUnaDevolucionAProveedor : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int iDDevolucionAProveedor;
        public int IDDevolucionAProveedor

        {
            get => iDDevolucionAProveedor;
            set => iDDevolucionAProveedor = value;
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


        public frmUnaDevolucionAProveedor()
        {
            InitializeComponent();
        }

        private void frmUnaDevolucionAProveedor_Load(object sender, EventArgs e)
        {
            iDDevolucionAProveedorTextBox.Text = IDDevolucionAProveedor.ToString();
            fechaTextBox.Text = Fecha.ToString();
            proveedorTextBox.Text = Proveedor;
            iDDevolucionAProveedorTextBox_Validating(sender, e);
        }

        private void iDDevolucionAProveedorTextBox_Validating(object sender, EventArgs e)
        {
            if (iDDevolucionAProveedorTextBox.Text == null) return;
            CADDevolucionProveedor miDevolucionAProveedor = CADDevolucionProveedor.DevolucionProveedorGetDevolucionProveedorByIDDevolucionProveedor(Convert.ToInt32(iDDevolucionAProveedorTextBox.Text));
            if (miDevolucionAProveedor == null)
            {
                fechaTextBox.Text = string.Empty;
                proveedorTextBox.Text = string.Empty;
                misDetalles.Clear();
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = misDetalles;
                PersonalizarGrilla();
                errorProvider1.SetError(iDDevolucionAProveedorTextBox, "No existe esta Devolución a Proveedor");
                return;
            }

            fechaTextBox.Text = miDevolucionAProveedor.Fecha.ToString();
            proveedorTextBox.Text = Proveedor;
            
            CAD.DSMiAppComercial.DevolucionProveedorDetalleDataTable miTabla = CADDevolucionProveedorDetalle.DevolucionProveedorDetalleGetDevolucionProveedorDetalleByIDDevolucionProveedor(miDevolucionAProveedor.IDDevolucionProveedor);
            foreach (CAD.DSMiAppComercial.DevolucionProveedorDetalleRow miRegistro in miTabla.Rows)
            {
                DetalleCompra miDetalle = new DetalleCompra();
                miDetalle.Cantidad = (float)miRegistro.Cantidad;
                miDetalle.Codigo = miRegistro.Codigo;
                miDetalle.Costo = (decimal) miRegistro.Precio;
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
    }
}