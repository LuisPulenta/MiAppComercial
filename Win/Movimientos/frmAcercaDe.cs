using CAD;
using System;
using System.Windows.Forms;

namespace Win.Movimientos
{
    public partial class frmAcercaDe : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void frmAcercaDe_Load(object sender, EventArgs e)
        {

        }
    }
}