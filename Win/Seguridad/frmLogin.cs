using CAD;
using System;
using System.Windows.Forms;

namespace Win
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "luis";
            txtClave.Text = "Espora2052";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar un Usuario");
                txtUsuario.Focus();
                return;
            }

            if (txtClave.Text == string.Empty)
            {
                errorProvider1.SetError(txtClave, "Debe ingresar una Clave");
                txtClave.Focus();
                return;
            }

            if (!CADUsuario.ValidaUsuario(txtUsuario.Text, txtClave.Text))
            {
                MessageBox.Show("Usuario o Clave no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
                txtUsuario.Focus();
                return;
            }

            frmPrincipal miForm = new frmPrincipal();
            miForm.UsuarioLogueado = CADUsuario.UsuarioGetUsuarioByIDUsuario(txtUsuario.Text);
            miForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
