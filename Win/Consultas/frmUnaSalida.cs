using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmUnaSalida : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int iDSalida;
        public int IDSalida

        {
            get => iDSalida;
            set => iDSalida = value;
        }

        private DateTime fecha;
        public DateTime Fecha

        {
            get => fecha;
            set => fecha = value;
        }

        private string concepto;
        public string Concepto

        {
            get => concepto;
            set => concepto = value;
        }

        private string almacen;
        public string Almacen

        {
            get => almacen;
            set => almacen = value;
        }

        private List<DetalleSalida2> misDetalles = new List<DetalleSalida2>();

        private int totalItems = 0;
        private decimal totalUltimoCosto = 0;
        private decimal totalCostoPromedio = 0;

        public frmUnaSalida()
        {
            InitializeComponent();
        }

        private void frmUnaSalida_Load(object sender, EventArgs e)
        {
            iDSalidaTextBox.Text = IDSalida.ToString();
            fechaTextBox.Text = Fecha.ToString();
            conceptoTextBox.Text = Concepto;
            almacenTextBox.Text = Almacen;
            iDSalidaTextBox_Validating(sender, e);
        }

        private void iDSalidaTextBox_Validating(object sender, EventArgs e)
        {
            if (iDSalidaTextBox.Text == null) return;
            CADSalida miSalida = CADSalida.SalidasGetSalidaByIDSalida(Convert.ToInt32(iDSalidaTextBox.Text));
            if (miSalida == null)
            {
                fechaTextBox.Text = string.Empty;
                conceptoTextBox.Text = string.Empty;
                almacenTextBox.Text = string.Empty;
                misDetalles.Clear();
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = misDetalles;
                PersonalizarGrilla();
                errorProvider1.SetError(iDSalidaTextBox, "No existe esta Salida");
                return;
            }

            fechaTextBox.Text = miSalida.Fecha.ToString();
            conceptoTextBox.Text = Concepto;
            almacenTextBox.Text = Almacen;

            CAD.DSMiAppComercial.SalidaDetalle2DataTable miTabla = CADSalidaDetalle2.SalidaDetalleGetSalidaDetalleByIDSalida(miSalida.IDSalida);
            foreach (CAD.DSMiAppComercial.SalidaDetalle2Row miRegistro in miTabla.Rows)
            {
                DetalleSalida2 miDetalle = new DetalleSalida2();
                miDetalle.Codigo = miRegistro.Codigo;
                miDetalle.Descripcion = miRegistro.Descripcion;
                miDetalle.UltimoCosto = miRegistro.UltimoCosto;
                miDetalle.CostoPromedio = miRegistro.CostoPromedio;
                miDetalle.Cantidad = (float) miRegistro.Cantidad;

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

            foreach (DetalleSalida2 miDetalle in misDetalles)
            {
                totalItems += 1;
                totalUltimoCosto += miDetalle.valorUltimoCosto;
                totalCostoPromedio += miDetalle.valorCostoPromedio;
            }

            totalItemsTextBox.Text = string.Format("{0:N0}", totalItems);
            totalCostoPromedioTextBox.Text = string.Format("{0:C2}", totalUltimoCosto);
            totalUltimoCostoTextBox.Text = string.Format("{0:C2}", totalCostoPromedio);
        }
    }
}

