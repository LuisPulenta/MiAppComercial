﻿using System;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Busqueda
{
    public partial class frmBusquedaProducto : Form
    {
        private int idElegido;

        public int IDElegido { get => idElegido; }

        public frmBusquedaProducto()
        {
            InitializeComponent();
        }

        private void frmBusquedaProducto_Load(object sender, EventArgs e)
        {
            unidadTableAdapter.Fill(dSMiAppComercial.Unidad);
            iVATableAdapter.Fill(dSMiAppComercial.IVA);
            categoriaTableAdapter.Fill(dSMiAppComercial.Categoria);
            productoTableAdapter.Fill(dSMiAppComercial.Producto);
            dgvDatos.AutoResizeColumns();
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string codigo, descripcion;

            if (rbtContenga.Checked)
            {
                codigo = "%" + codigoToolStripTextBox.Text + "%";
                descripcion = "%" + descripcionToolStripTextBox.Text + "%";
            }

            else if (rbtEmpiece.Checked)
            {
                codigo = codigoToolStripTextBox.Text + "%";
                descripcion = descripcionToolStripTextBox.Text + "%";
            }
            else if (rbtTermina.Checked)
            {
                codigo = "%" + codigoToolStripTextBox.Text;
                descripcion = "%" + descripcionToolStripTextBox.Text;
            }
            else
            {
                codigo = codigoToolStripTextBox.Text;
                descripcion = descripcionToolStripTextBox.Text;
            }
            try
            {
                this.productoTableAdapter.FillBy1(
                    this.dSMiAppComercial.Producto,
                    codigo,
                    descripcion);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnQuitarFiltros_Click(object sender, EventArgs e)
        {
            codigoToolStripTextBox.Text = string.Empty;
            descripcionToolStripTextBox.Text = string.Empty;
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