using CAD;
using System;
using System.Windows.Forms;

namespace Win
{
    public partial class frmPrincipal : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            nombresUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;
        }
    }
}
