using CAD;
using System;
using System.Windows.Forms;
using Win.Consultas;
using Win.Maestros;
using Win.Movimientos;
using Win.Seguridad;

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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Realmente desea salir de la aplicación?", "Salir del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmPrincipal_FormClosing(object sender, EventArgs e)
        {
                Application.Exit();
        }



        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            nombresUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;
            VerificaCambioClave(sender, e);
        }

        private void VerificaCambioClave(object sender, System.EventArgs e)
        {
            if (usuarioLogueado.FechaModificacionClave.AddDays(30) < DateTime.Now)
            {
                cambioDeClaveToolStripMenuItem_Click(sender, e);
            }
        }


        private void cambioDeUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCambioUsuario miForm = new frmCambioUsuario();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.ShowDialog();
            if (miForm.UsuarioLogueado != null)
            {
                usuarioLogueado = miForm.UsuarioLogueado;
            }
            nombresUsuarioToolStripStatusLabel.Text = "Usuario: " + usuarioLogueado.Nombre + " " + usuarioLogueado.Apellido;

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuarios miForm = new frmUsuarios();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias miForm = new frmCategorias();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnidades miForm = new frmUnidades();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void almacenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlmacenes miForm = new frmAlmacenes();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void conceptosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConceptos miForm = new frmConceptos();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void iVAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIVAs miForm = new frmIVAs();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tiposDeDocumentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTiposDocumento miForm = new frmTiposDocumento();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClientes miForm = new frmClientes();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbClientes_Click(object sender, EventArgs e)
        {
            clientesToolStripMenuItem1_Click(sender, e);
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProveedores miForm = new frmProveedores();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbProveedores_Click(object sender, EventArgs e)
        {
            proveedoresToolStripMenuItem1_Click(sender, e);
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProductos miForm = new frmProductos();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbProductos_Click(object sender, EventArgs e)
        {
            productosToolStripMenuItem2_Click(sender, e);
        }

        private void cambioDeClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambioClave miForm = new frmCambioClave();
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras miForm = new frmCompras();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbCompras_Click(object sender, EventArgs e)
        {
            comprasToolStripMenuItem_Click(sender, e);
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas miForm = new frmVentas();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbVentas_Click(object sender, EventArgs e)
        {
            ventasToolStripMenuItem_Click(sender, e);
        }

        private void verificarConsistenciaDeKardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
                "¿Está seguro de querer verificar la consistencia del Kardex?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;
            CADKardex.ReKardex();
            MessageBox.Show("Verificación de Kardex finalizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaKardex miForm = new frmConsultaKardex();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalidas miForm = new frmSalidas();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbSalidas_Click(object sender, EventArgs e)
        {
            salidasToolStripMenuItem_Click (sender, e);
        }

        private void tsbKardex_Click(object sender, EventArgs e)
        {
            kardexToolStripMenuItem_Click(sender, e);
        }

        private void deClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucionClientes miForm = new frmDevolucionClientes();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void aProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDevolucionProveedores miForm = new frmDevolucionProveedores();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbDevolucionClientes_Click(object sender, EventArgs e)
        {
            deClientesToolStripMenuItem_Click(sender, e);
        }

        private void tsbDevolucionProveedores_Click(object sender, EventArgs e)
        {
            aProveedoresToolStripMenuItem_Click(sender, e);
        }

        private void trasladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraslados miForm = new frmTraslados();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void tsbTraslados_Click(object sender, EventArgs e)
        {
            trasladosToolStripMenuItem_Click(sender, e);
        }

        private void paso1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioFisicoPaso1 miForm = new frmInventarioFisicoPaso1();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void paso2IngresarPrimerConteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioFisicoPaso2 miForm = new frmInventarioFisicoPaso2();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void paso3IngresarSegundoConteoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioFisicoPaso3 miForm = new frmInventarioFisicoPaso3();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void paso4IngresarCOnteoFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventarioFisicoPaso4 miForm = new frmInventarioFisicoPaso4();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void cancelarInventariosNoTerminadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCancelarInventariosNoTerminados miForm = new frmCancelarInventariosNoTerminados();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCompras miForm = new frmConsultaCompras();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaVentas miForm = new frmConsultaVentas();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void salidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSalidas miForm = new frmConsultaSalidas();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }

        private void trasladosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaTraslados miForm = new frmConsultaTraslados();
            miForm.MdiParent = this;
            miForm.UsuarioLogueado = usuarioLogueado;
            miForm.Show();
        }
    }
}