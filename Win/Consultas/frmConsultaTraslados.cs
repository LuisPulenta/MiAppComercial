using CAD;
using System;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmConsultaTraslados : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private decimal totalCostoPromedio = 0;
        private decimal totalUltimoCosto = 0;

        public frmConsultaTraslados()
        {
            InitializeComponent();
        }

        private void frmConsultaTraslados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            

            almacenOrigenComboBox.SelectedIndex = -1;
            almacenDestinoComboBox.SelectedIndex = -1;
            hastaDateTimePicker.Value = DateTime.Now;
            desdeDateTimePicker.Value = DateTime.Now.AddDays(-30);
            LlenarGrilla();

            dgvDatos.AutoResizeColumns();

        }

        private void almacenOrigenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void almacenDestinoComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
            totalCostoPromedio = 0;
            totalUltimoCosto = 0;

            if (almacenOrigenComboBox.SelectedIndex != -1 && almacenDestinoComboBox.SelectedIndex != -1)
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

                this.trasladosConsultaTableAdapter.Fill(this.dSMiAppComercial.TrasladosConsulta, (int)almacenOrigenComboBox.SelectedValue, (int)almacenDestinoComboBox.SelectedValue, Convert.ToDateTime(fechaDesde), Convert.ToDateTime(fechaHasta));


                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    totalCostoPromedio = totalCostoPromedio + Convert.ToDecimal(row.Cells[5].Value);
                    totalUltimoCosto = totalUltimoCosto + Convert.ToDecimal(row.Cells[5].Value);
                }


                dgvDatos.AutoResizeColumns();
                totalCostoPromedioTextBox.Text = string.Format("{0:C2}", totalCostoPromedio);
                totalUltimoCostoTextBox.Text = string.Format("{0:C2}", totalUltimoCosto);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
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
