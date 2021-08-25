using System;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Busqueda
{
    public partial class frmBusquedaClientes : Form
    {
        private int idElegido;

        public int IDElegido { get => idElegido; }

        public frmBusquedaClientes()
        {
            InitializeComponent();
        }

        private void frmBusquedaClientes_Load(object sender, EventArgs e)
        {
            clienteTableAdapter.Fill(dSMiAppComercial.Cliente);
            dgvDatos.AutoResizeColumns();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            string documento, nombreComercial, nombreContacto, apellidoContacto;

            if (rbtContenga.Checked)
            {
                documento = "%" + documentoToolStripTextBox.Text + "%";
                nombreComercial = "%" + nombreComercialToolStripTextBox.Text + "%";
                nombreContacto = "%" + nombreContactoToolStripTextBox.Text + "%";
                apellidoContacto = "%" + apellidoContactoToolStripTextBox.Text + "%";
            }

            else if (rbtEmpiece.Checked)
            {
                documento = documentoToolStripTextBox.Text + "%";
                nombreComercial = nombreComercialToolStripTextBox.Text + "%";
                nombreContacto = nombreContactoToolStripTextBox.Text + "%";
                apellidoContacto = apellidoContactoToolStripTextBox.Text + "%";
            }
            else if (rbtTermina.Checked)
            {
                documento = "%" + documentoToolStripTextBox.Text;
                nombreComercial = "%" + nombreComercialToolStripTextBox.Text;
                nombreContacto = "%" + nombreContactoToolStripTextBox.Text;
                apellidoContacto = "%" + apellidoContactoToolStripTextBox.Text;
            }
            else
            {
                documento = documentoToolStripTextBox.Text;
                nombreComercial = nombreComercialToolStripTextBox.Text;
                nombreContacto = nombreContactoToolStripTextBox.Text;
                apellidoContacto = apellidoContactoToolStripTextBox.Text;
            }
            try
            {
                clienteTableAdapter.FillBy(
                    dSMiAppComercial.Cliente,
                    documento,
                    nombreComercial,
                    nombreContacto,
                    apellidoContacto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            documentoToolStripTextBox.Text = string.Empty;
            nombreComercialToolStripTextBox.Text = string.Empty;
            nombreContactoToolStripTextBox.Text = string.Empty;
            apellidoContactoToolStripTextBox.Text = string.Empty;
            fillByToolStripButton_Click(sender, e);
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

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportarDatosAExcel.ExportarDatos(dgvDatos);
        }
    }
}
