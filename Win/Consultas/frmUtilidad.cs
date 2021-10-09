using CAD;
using System;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmUtilidad : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmUtilidad()
        {
            InitializeComponent();
        }

        private void frmUtilidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.dSMiAppComercial.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            
            almacenComboBox.SelectedIndex = -1;
            categoriaComboBox.SelectedIndex = -1;
        }

        private void almacenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
                this.utilidadTableAdapter.Fill(this.dSMiAppComercial.Utilidad, Convert.ToInt32(almacenComboBox.SelectedValue), Convert.ToInt32(categoriaComboBox.SelectedValue));
                dgvDatos.AutoResizeColumns();
        }

        private void chkElegir_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElegir.Checked)
            {
                dgvDatos.Columns[0].Visible = true;
            }
            else
            {
                dgvDatos.Columns[0].Visible = false;
            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDatos.Columns["Elegir"].Index)
            {
                DataGridViewCheckBoxCell ChkElegir = (DataGridViewCheckBoxCell)dgvDatos.Rows[e.RowIndex].Cells["Elegir"];
                ChkElegir.Value = !Convert.ToBoolean(ChkElegir.Value);
                ActualizarNuevoPrecio();
                dgvDatos.AutoResizeColumns();
            }
        }

        private void ActualizarNuevoPrecio()
        {
            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
              if(row.Cells["Elegir"].Value != null)
                {
                    if ((bool)row.Cells["Elegir"].Value == true)
                    {
                        row.Cells["NuevoPrecio"].Value = (decimal)row.Cells["Precio"].Value * (1 + nuPorcPrecio.Value / 100);
                        row.Cells["NuevoCosto"].Value = (decimal)row.Cells["Costo"].Value * (1 + nuPorcCosto.Value / 100);
                        row.Cells["NuevaUtil"].Value = (decimal)row.Cells["Precio"].Value * (1 + nuPorcPrecio.Value / 100)-(decimal)row.Cells["Costo"].Value * (1 + nuPorcCosto.Value / 100);
                    }
                    else
                    {
                        row.Cells["NuevoPrecio"].Value = (decimal)row.Cells["Precio"].Value;
                        row.Cells["NuevoCosto"].Value = (decimal)row.Cells["Costo"].Value;
                        row.Cells["NuevaUtil"].Value = (decimal)row.Cells["Precio"].Value - (decimal)row.Cells["Costo"].Value;
                    }
                }
              else
                {
                    row.Cells["NuevoPrecio"].Value = (decimal)row.Cells["Precio"].Value;
                    row.Cells["NuevoCosto"].Value = (decimal)row.Cells["Costo"].Value;
                    row.Cells["NuevaUtil"].Value = (decimal)row.Cells["Utilidad"].Value;
                }
                
            }
            dgvDatos.AutoResizeColumns();
        }

        private void btnSeleccionarTodo_Click(object sender, EventArgs e)
        {
            if(!chkElegir.Checked)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                row.Cells[0].Value = true;
            }
            ActualizarNuevoPrecio();
        }

        private void btnDeseleccionarTodo_Click(object sender, EventArgs e)
        {
            if (!chkElegir.Checked)
            {
                return;
            }

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                row.Cells[0].Value = false;
            }
            ActualizarNuevoPrecio();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }

        private void nuPorcPrecio_ValueChanged(object sender, EventArgs e)
        {
            ActualizarNuevoPrecio();
        }

        private void nuPorcCosto_ValueChanged(object sender, EventArgs e)
        {
            ActualizarNuevoPrecio();
        }

        private void nuPorcUtilidad_ValueChanged(object sender, EventArgs e)
        {
            ActualizarNuevoPrecio();
        }
    }
}