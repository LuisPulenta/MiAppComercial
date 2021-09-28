using CAD;
using System;
using System.Windows.Forms;

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

        private decimal totalCostoPromedio = 0;
        private decimal totalUltimoCosto = 0;

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

            //LlenarGrilla();

            dgvDatos.AutoResizeColumns();

        }
    }
}
