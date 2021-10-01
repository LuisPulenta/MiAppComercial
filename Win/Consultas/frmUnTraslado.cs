using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmUnTraslado : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int iDTraslado;
        public int IDTraslado

        {
            get => iDTraslado;
            set => iDTraslado = value;
        }

        private DateTime fecha;
        public DateTime Fecha

        {
            get => fecha;
            set => fecha = value;
        }

        private string almacenOrigen;
        public string AlmacenOrigen

        {
            get => almacenOrigen;
            set => almacenOrigen = value;
        }

        private string almacenDestino;
        public string AlmacenDestino

        {
            get => almacenDestino;
            set => almacenDestino = value;
        }

        private List<DetalleTraslado2> misDetalles = new List<DetalleTraslado2>();

        private int totalItems = 0;
        private decimal totalUltimoCosto = 0;
        private decimal totalCostoPromedio = 0;

        public frmUnTraslado()
        {
            InitializeComponent();
        }

        private void frmUnTraslado_Load(object sender, EventArgs e)
        {
            iDTrasladoTextBox.Text = IDTraslado.ToString();
            fechaTextBox.Text = Fecha.ToString();
            almacenOrigenTextBox.Text = AlmacenOrigen;
            almacenDestinoTextBox.Text = AlmacenDestino;
            iDTrasladoTextBox_Validating(sender, e);
        }

        private void iDTrasladoTextBox_Validating(object sender, EventArgs e)
        {
            fechaTextBox.Text = string.Empty;
            almacenOrigenTextBox.Text = string.Empty;
            almacenDestinoTextBox.Text = string.Empty;
            misDetalles.Clear();
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;
            PersonalizarGrilla();

            if (iDTrasladoTextBox.Text == null) return;
            CADTraslado miTraslado = CADTraslado.TrasladosGetTrasladoByIDTraslado(Convert.ToInt32(iDTrasladoTextBox.Text));
            if (miTraslado == null)
            {
               
                errorProvider1.SetError(iDTrasladoTextBox, "No existe este Traslado");
                iDTrasladoTextBox.Focus();
                return;
            }

            fechaTextBox.Text = miTraslado.Fecha.ToString();
            almacenOrigenTextBox.Text = AlmacenOrigen;
            almacenDestinoTextBox.Text = AlmacenDestino;

            CAD.DSMiAppComercial.TrasladoDetalle2DataTable miTabla = CADTrasladoDetalle2.TrasladoDetalleGetTrasladoDetalleByIDTraslado(miTraslado.IDTraslado);
            foreach (CAD.DSMiAppComercial.TrasladoDetalle2Row miRegistro in miTabla.Rows)
            {
                DetalleTraslado2 miDetalle = new DetalleTraslado2();
                miDetalle.Codigo = miRegistro.Codigo;
                miDetalle.Descripcion = miRegistro.Descripcion;
                miDetalle.UltimoCosto = miRegistro.UltimoCosto;
                miDetalle.CostoPromedio = miRegistro.CostoPromedio;
                miDetalle.Cantidad = (float)miRegistro.Cantidad;

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

            dgvDatos.Columns["UltimoCosto"].HeaderText = "Último Costo";
            dgvDatos.Columns["UltimoCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["UltimoCosto"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["CostoPromedio"].HeaderText = "Costo Promedio";
            dgvDatos.Columns["CostoPromedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["CostoPromedio"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["valorUltimoCosto"].HeaderText = "Valor Último Costo";
            dgvDatos.Columns["valorUltimoCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorUltimoCosto"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["valorCostoPromedio"].HeaderText = "Valor Costo Promedio";
            dgvDatos.Columns["valorCostoPromedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorCostoPromedio"].DefaultCellStyle.Format = "C2";

            totalItems = 0;
            totalUltimoCosto = 0;
            totalCostoPromedio = 0;

            foreach (DetalleTraslado2 miDetalle in misDetalles)
            {
                totalItems += 1;
                totalUltimoCosto += miDetalle.valorUltimoCosto;
                totalCostoPromedio += miDetalle.valorCostoPromedio;
            }

            totalItemsTextBox.Text = string.Format("{0:N0}", totalItems);
            totalCostoPromedioTextBox.Text = string.Format("{0:C2}", totalUltimoCosto);
            totalUltimoCostoTextBox.Text = string.Format("{0:C2}", totalCostoPromedio);
        }

        private void iDTrasladoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                iDTrasladoTextBox_Validating(sender, e);
        }
    }
}

