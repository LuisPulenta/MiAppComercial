using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmUnaDevolucionDeCliente : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int iDDevolucionDeCliente;
        public int IDDevolucionDeCliente

        {
            get => iDDevolucionDeCliente;
            set => iDDevolucionDeCliente = value;
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

        public frmUnaDevolucionDeCliente()
        {
            InitializeComponent();
        }

        private void frmUnaDevolucionDeCliente_Load(object sender, EventArgs e)
        {
            iDDevolucionDeClienteTextBox.Text = IDDevolucionDeCliente.ToString();
            fechaTextBox.Text = Fecha.ToString();
            clienteTextBox.Text = Cliente;
            iDDevolucionDeClienteTextBox_Validating(sender, e);
        }

        private void iDDevolucionDeClienteTextBox_Validating(object sender, EventArgs e)
        {
            if (iDDevolucionDeClienteTextBox.Text == null) return;
            CADDevolucionCliente miDevolucionDeCliente = CADDevolucionCliente.DevolucionClienteGetDevolucionClienteByIDDevolucionCliente(Convert.ToInt32(iDDevolucionDeClienteTextBox.Text));
            if (miDevolucionDeCliente == null)
            {
                fechaTextBox.Text = string.Empty;
                clienteTextBox.Text = string.Empty;
                misDetalles.Clear();
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = misDetalles;
                PersonalizarGrilla();
                errorProvider1.SetError(iDDevolucionDeClienteTextBox, "No existe esta Devolución de Cliente");
                return;
            }

            fechaTextBox.Text = miDevolucionDeCliente.Fecha.ToString();
            clienteTextBox.Text = Cliente;

            CAD.DSMiAppComercial.DevolucionClienteDetalleDataTable miTabla = CADDevolucionClienteDetalle.DevolucionClienteDetalleGetDevolucionClienteDetalleByIDDevolucionCliente(miDevolucionDeCliente.IDDevolucionCliente);
            foreach (CAD.DSMiAppComercial.DevolucionClienteDetalleRow miRegistro in miTabla.Rows)
            {
                DetalleVenta miDetalle = new DetalleVenta();
                miDetalle.Cantidad = (float)miRegistro.Cantidad;
                miDetalle.Codigo = miRegistro.Codigo;
                miDetalle.Precio = (decimal)miRegistro.Precio;
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
    }
}