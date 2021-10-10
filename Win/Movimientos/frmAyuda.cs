using CAD;
using System;
using System.Windows.Forms;

namespace Win.Movimientos
{
    public partial class frmAyuda : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmAyuda()
        {
            InitializeComponent();
        }

        private void frmAyuda_Load(object sender, EventArgs e)
        {

        }
    }
}
