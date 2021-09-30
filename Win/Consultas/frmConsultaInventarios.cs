using CAD;
using System;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmConsultaInventarios : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private decimal totalSobranteCostoPromedio = 0;
        private decimal totalFaltanteCostoPromedio = 0;
        private decimal totalSobranteUltimoCosto = 0;
        private decimal totalFaltanteUltimoCosto = 0;

        public frmConsultaInventarios()
        {
            InitializeComponent();
        }

        private void frmConsultaInventarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            almacenComboBox.SelectedIndex = -1;
            hastaDateTimePicker.Value = DateTime.Now;
            desdeDateTimePicker.Value = DateTime.Now.AddDays(-30);
            LlenarGrilla();
            dgvDatos.AutoResizeColumns();

        }

        private void resetDesdeButton_Click(object sender, EventArgs e)
        {
            desdeDateTimePicker.Value = DateTime.Now.AddDays(-30);
        }

        private void resetHastaButton_Click(object sender, EventArgs e)
        {
            hastaDateTimePicker.Value = DateTime.Now;
        }

        private void almacenComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
            totalSobranteCostoPromedio = 0;
            totalFaltanteCostoPromedio = 0;
            totalSobranteUltimoCosto = 0;
            totalFaltanteUltimoCosto = 0;

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

                this.inventariosConsultaTableAdapter.Fill(this.dSMiAppComercial.InventariosConsulta, (int)almacenComboBox.SelectedValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));


                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    totalSobranteUltimoCosto = totalSobranteUltimoCosto + Convert.ToDecimal(row.Cells[8].Value);
                    totalFaltanteUltimoCosto = totalFaltanteUltimoCosto + Convert.ToDecimal(row.Cells[9].Value);
                    totalSobranteCostoPromedio = totalSobranteCostoPromedio + Convert.ToDecimal(row.Cells[10].Value);
                    totalFaltanteCostoPromedio = totalFaltanteCostoPromedio + Convert.ToDecimal(row.Cells[11].Value);
                }


                dgvDatos.AutoResizeColumns();

                dgvDatos.Columns["Inventario"].Width = 60;
                dgvDatos.Columns["Items"].Width = 60;
                dgvDatos.Columns["ItemsOk"].Width = 60;
                dgvDatos.Columns["ItemsConSobrante"].Width = 60;
                dgvDatos.Columns["ItemsConFaltantes"].Width = 60;
                dgvDatos.Columns["SobranteAÚltimoCosto"].Width = 120;
                dgvDatos.Columns["FaltanteAÚltimoCosto"].Width = 120;
                dgvDatos.Columns["SobranteACostoPromedio"].Width = 120;
                dgvDatos.Columns["FaltanteACostoPromedio"].Width = 120;

                totalSobranteCostoPromedioTextBox.Text = string.Format("{0:C2}", totalSobranteCostoPromedio);
                totalFaltanteCostoPromedioTextBox.Text = string.Format("{0:C2}", totalFaltanteCostoPromedio);
                totalSobranteUltimoCostoTextBox.Text = string.Format("{0:C2}", totalSobranteUltimoCosto);
                totalFaltanteUltimoCostoTextBox.Text = string.Format("{0:C2}", totalFaltanteUltimoCosto);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }

        private void dgvDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUnInventario miVenta = new frmUnInventario();
            int selectedrowindex = dgvDatos.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvDatos.Rows[selectedrowindex];
            miVenta.IDInventario = (int)selectedRow.Cells[0].Value;
            miVenta.Fecha = (DateTime)selectedRow.Cells[1].Value;
            miVenta.Categoria = selectedRow.Cells[3].Value.ToString();
            miVenta.Almacen = selectedRow.Cells[2].Value.ToString();
            miVenta.ShowDialog();
        }
    }
}

