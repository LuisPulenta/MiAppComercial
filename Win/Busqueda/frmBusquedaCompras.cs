using System;

using System.Windows.Forms;

namespace Win.Busqueda
{
    public partial class frmBusquedaCompras : Form
    {
        private int idElegido;

        public int IDElegido { get => idElegido; }

        public frmBusquedaCompras()
        {
            InitializeComponent();
        }

        private void frmBusquedaCompras_Load(object sender, EventArgs e)
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

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmBusquedaProveedor miBusqueda = new frmBusquedaProveedor();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            proveedorComboBox.SelectedValue = miBusqueda.IDElegido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            idElegido = 0;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count == 0)
            {
                idElegido = 0;
            }
            else if (dgvDatos.SelectedRows.Count != 0)
            {
                idElegido = Convert.ToInt32(dgvDatos.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                idElegido = Convert.ToInt32(dgvDatos.Rows[0].Cells[0].Value);
            }
            this.Close();
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
            if ((almacenComboBox.SelectedIndex != -1) && (proveedorComboBox.SelectedIndex != -1))
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

                this.compraBusquedaTableAdapter.Fill(this.dSMiAppComercial.CompraBusqueda, (int)almacenComboBox.SelectedValue, (int)proveedorComboBox.SelectedValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));
                dgvDatos.AutoResizeColumns();
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
    }
}
