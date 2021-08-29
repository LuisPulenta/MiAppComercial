using CAD;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Win.Seguridad
{
    public partial class frmCambioClave : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        public frmCambioClave()
        {
            InitializeComponent();
        }

        private void frmCambioClave_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.claveAnteriorTextBox, "Ingrese la Clave anterior");
            this.toolTip1.SetToolTip(this.nuevaClaveTextBox, "Ingrese la Nueva Clave");
            this.toolTip1.SetToolTip(this.confirmacionTextBox, "Confirme la Nueva Clave");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (claveAnteriorTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(claveAnteriorTextBox, "Debe ingresar la Clave actual");
                claveAnteriorTextBox.Focus();
                return;
            }

            if (claveAnteriorTextBox.Text != usuarioLogueado.Clave)
            {
                errorProvider1.SetError(claveAnteriorTextBox, "Clave actual incorrecta");
                claveAnteriorTextBox.Focus();
                return;
            }

            if (nuevaClaveTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "Debe ingresar la Nueva Clave");
                nuevaClaveTextBox.Focus();
                return;
            }

            if (nuevaClaveTextBox.Text.Length < 8)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "La Clave debe ser de al menos 8 caracteres");
                nuevaClaveTextBox.Focus();
                return ;
            }

            if (nuevaClaveTextBox.Text.Length > 20)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "La Clave no puede tener más de 20 caracteres");
                nuevaClaveTextBox.Focus();
                return ;
            }

            if (!nuevaClaveTextBox.Text.Any(c => char.IsUpper(c)))
            {
                errorProvider1.SetError(nuevaClaveTextBox, "La Clave debe contener al menos una letra mayúscula");
                nuevaClaveTextBox.Focus();
                return ;
            }

            if (!nuevaClaveTextBox.Text.Any(c => char.IsLower(c)))
            {
                errorProvider1.SetError(nuevaClaveTextBox, "La Clave debe contener al menos una letra minúscula");
                nuevaClaveTextBox.Focus();
                return ;
            }

            if (confirmacionTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(confirmacionTextBox, "Debe ingresar la Confirmacion");
                confirmacionTextBox.Focus();
                return;
            }

            if (nuevaClaveTextBox.Text != confirmacionTextBox.Text)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "La nueva Clave y su confirmación no coinciden");
                errorProvider1.SetError(confirmacionTextBox, "La nueva Clave y su confirmación no coinciden");
                confirmacionTextBox.Focus();
                return;
            }

            CADUsuario.UsuarioUpdateClave(nuevaClaveTextBox.Text, usuarioLogueado.IDUsuario);
            MessageBox.Show("Cambio de Clave realizado con éxito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            usuarioLogueado.Clave = nuevaClaveTextBox.Text;
            usuarioLogueado.FechaModificacionClave = DateTime.Now;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void frmCambioClave_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (usuarioLogueado.FechaModificacionClave.AddDays(30) < DateTime.Now)
            {
                errorProvider1.SetError(nuevaClaveTextBox, "Debe cambiar la Clave");
                nuevaClaveTextBox.Focus();
                e.Cancel = true;
                return;
            }
        }
    }
}