using CAD;
using System;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmConsultaVentas : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private decimal totalNeto = 0;

        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void frmConsultaVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.FillBy2(this.dSMiAppComercial.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            almacenComboBox.SelectedIndex = -1;
            clienteComboBox.SelectedIndex = -1;
            hastaDateTimePicker.Value = DateTime.Now;
            desdeDateTimePicker.Value = DateTime.Now.AddDays(-30);

            LlenarGrilla();

            dgvDatos.AutoResizeColumns();

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clienteTableAdapter.FillBy2(this.dSMiAppComercial.Cliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBusquedaClientes miBusqueda = new frmBusquedaClientes();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            clienteComboBox.SelectedValue = miBusqueda.IDElegido;
        }

        private void almacenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void clienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
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

                if (clientesCheckBox.Checked)
                {
                    this.ventaBusquedaTableAdapter.Fill2(this.dSMiAppComercial.VentaBusqueda, (int)almacenComboBox.SelectedValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                }
                else
                {
                    if (clienteComboBox.SelectedIndex == -1)
                    {
                        clienteComboBox.Focus();
                        this.ventaBusquedaTableAdapter.Fill(this.dSMiAppComercial.VentaBusqueda, (int)almacenComboBox.SelectedValue, int.MaxValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                        totalNeto = 0;
                        totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);
                        return;
                    }
                    this.ventaBusquedaTableAdapter.Fill(this.dSMiAppComercial.VentaBusqueda, (int)almacenComboBox.SelectedValue, (int)clienteComboBox.SelectedValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                }

                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    totalNeto = totalNeto + Convert.ToDecimal(row.Cells[5].Value);
                }


                dgvDatos.AutoResizeColumns();
                totalNetoTextBox.Text = string.Format("{0:C2}", totalNeto);
            }
        }

        private void resetDesdeButton_Click(object sender, EventArgs e)
        {
            desdeDateTimePicker.Value = DateTime.Now.AddDays(-30);
        }

        private void resetHastaButton_Click(object sender, EventArgs e)
        {
            hastaDateTimePicker.Value = DateTime.Now;
        }

        private void clientesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (clientesCheckBox.Checked)
            {
                clienteComboBox.SelectedIndex = -1;
                clienteComboBox.Enabled = false;
                btnBuscarCliente.Enabled = false;
            }
            else
            {
                clienteComboBox.Enabled = true;
                btnBuscarCliente.Enabled = true;
            }
            LlenarGrilla();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUnaVenta miVenta = new frmUnaVenta();
            int selectedrowindex = dgvDatos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvDatos.Rows[selectedrowindex];
            miVenta.IDVenta = (int)selectedRow.Cells[0].Value;
            miVenta.Fecha = (DateTime)selectedRow.Cells[1].Value;
            miVenta.Cliente = selectedRow.Cells[2].Value.ToString();
            miVenta.Almacen = selectedRow.Cells[3].Value.ToString();
            miVenta.ShowDialog();
        }
    }
}
