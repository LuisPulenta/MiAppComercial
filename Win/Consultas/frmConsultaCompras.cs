using CAD;
using System;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmConsultaCompras : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private decimal totalNeto = 0;

        public frmConsultaCompras()
        {
            InitializeComponent();
        }

        private void frmConsultaCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.FillBy2(this.dSMiAppComercial.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            almacenComboBox.SelectedIndex = -1;
            proveedorComboBox.SelectedIndex = -1;
            hastaDateTimePicker.Value = DateTime.Now;
            desdeDateTimePicker.Value = DateTime.Now.AddDays(-30);

            LlenarGrilla();

            dgvDatos.AutoResizeColumns();

        }

        private void almacenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void proveedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void desdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void hastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            totalNeto = 0;

            if (almacenComboBox.SelectedIndex != -1)
            {
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

                if (proveedoresCheckBox.Checked)
                {
                    this.compraBusquedaTableAdapter.Fill2(this.dSMiAppComercial.CompraBusqueda, (int)almacenComboBox.SelectedValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                }
                else
                {
                    if(proveedorComboBox.SelectedIndex == -1)
                    {
                        proveedorComboBox.Focus();
                        this.compraBusquedaTableAdapter.Fill(this.dSMiAppComercial.CompraBusqueda, (int)almacenComboBox.SelectedValue, int.MaxValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                        totalNeto = 0;
                        totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);
                        return;
                    }
                    this.compraBusquedaTableAdapter.Fill(this.dSMiAppComercial.CompraBusqueda, (int)almacenComboBox.SelectedValue, (int)proveedorComboBox.SelectedValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                }

                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    totalNeto = totalNeto + Convert.ToDecimal(row.Cells[5].Value);
                }


                dgvDatos.AutoResizeColumns();
                totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
          ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }

        private void proveedoresCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(proveedoresCheckBox.Checked)
            {
                proveedorComboBox.SelectedIndex = -1;
                proveedorComboBox.Enabled = false;
                btnBuscarProveedor.Enabled = false;
            }
            else
            {
                proveedorComboBox.Enabled = true;
                btnBuscarProveedor.Enabled = true;
            }
            LlenarGrilla();
        }

        private void resetDesdeButton_Click(object sender, EventArgs e)
        {
            desdeDateTimePicker.Value = DateTime.Now.AddDays(-30);
        }

        private void resetHastaButton_Click(object sender, EventArgs e)
        {
            hastaDateTimePicker.Value = DateTime.Now;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDElegido;
        }
    }
}