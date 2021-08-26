﻿using CAD;
using System;
using System.Windows.Forms;
using Win.Maestros;

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
        }

        private void cambioDeUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
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
    }
}
