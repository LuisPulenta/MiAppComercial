using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Movimientos
{
    public partial class frmInventarioFisicoPaso2 : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private List<MaterialAContar> misMaterialesAContar = new List<MaterialAContar>();

        public frmInventarioFisicoPaso2()
        {
            InitializeComponent();
        }

        private void frmInventarioFisicoPaso2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.dSMiAppComercial.Inventario);

            IDInventarioComboBox.SelectedIndex = -1;
            dgvDatos.AutoResizeColumns();
            btnGuardar.Enabled = false;
        }

        private void IDInventarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            if (IDInventarioComboBox.SelectedValue == null) return;


            int InventarioID = (int)IDInventarioComboBox.SelectedValue;
            misMaterialesAContar.Clear();

            CAD.DSMiAppComercial.MaterialAContarDataTable miTabla = CADMaterialAContar.GetData(InventarioID);
            foreach (CAD.DSMiAppComercial.MaterialAContarRow miRegistro in miTabla.Rows)
            {
                MaterialAContar miMaterialAContar = new MaterialAContar();
                miMaterialAContar.IDLinea = (int) miRegistro.IDLinea;
                miMaterialAContar.Codigo = miRegistro.Codigo;
                miMaterialAContar.Descripcion = miRegistro.Descripcion;
                miMaterialAContar.Unidad = miRegistro.Unidad;
                miMaterialAContar.Medida = (int) miRegistro.Medida;
                miMaterialAContar.Stock = (float)miRegistro.Stock;
                miMaterialAContar.Conteo1 = (float)miRegistro.Conteo1;
                miMaterialAContar.Conteo2 = (float)miRegistro.Conteo2;
                miMaterialAContar.Conteo3 = (float)miRegistro.Conteo3;
                misMaterialesAContar.Add(miMaterialAContar);
            }

            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misMaterialesAContar;
            PersonalizarGrilla();
            dgvDatos.AutoResizeColumns();
        }

        private void PersonalizarGrilla()
        {
            dgvDatos.Columns["IDLinea"].Visible = false;

            dgvDatos.Columns["Codigo"].HeaderText = "Código";
            dgvDatos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns["Codigo"].ReadOnly = true;

            dgvDatos.Columns["Descripcion"].HeaderText = "Descripción";
            dgvDatos.Columns["Descripcion"].ReadOnly = true;

            dgvDatos.Columns["Unidad"].HeaderText = "Un";
            dgvDatos.Columns["Unidad"].ReadOnly = true;
            dgvDatos.Columns["Unidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatos.Columns["Medida"].ReadOnly = true;
            dgvDatos.Columns["Medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatos.Columns["Stock"].HeaderText = "Stock";
            dgvDatos.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Stock"].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns["Stock"].ReadOnly = true;

            dgvDatos.Columns["Conteo1"].HeaderText = "Conteo 1";
            dgvDatos.Columns["Conteo1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Conteo1"].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns["Conteo1"].ReadOnly = false;

            dgvDatos.Columns["Conteo2"].HeaderText = "Conteo 2";
            dgvDatos.Columns["Conteo2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Conteo2"].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns["Conteo2"].ReadOnly = false;
            dgvDatos.Columns["Conteo2"].Visible = false;

            dgvDatos.Columns["Conteo3"].HeaderText = "Conteo 3";
            dgvDatos.Columns["Conteo3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Conteo3"].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns["Conteo3"].ReadOnly = false;
            dgvDatos.Columns["Conteo3"].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
          "¿Está seguro de guardar el Primer Conteo?",
          "Confirmación",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No)
            {
                return;
            }

            foreach(MaterialAContar miMaterialAContar in misMaterialesAContar)
            {
                CADInventarioDetalle.InventarioDetalleUpDateConteo1(miMaterialAContar.Conteo1, miMaterialAContar.IDLinea);
            }

            CADInventario.InventarioUpDatePaso(2, (int) IDInventarioComboBox.SelectedValue);

            MessageBox.Show(
                string.Format("El Conteo 1 fue grabado de forma exitosa. Puede proceder a realizar el Conteo 2."),
                "Aviso!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(IDInventarioComboBox.SelectedIndex==-1)
            {
                return;
            }
            frmConteo1 frm = new frmConteo1();
            frm.IdInventario = Convert.ToInt32(IDInventarioComboBox.SelectedValue);
            frm.ShowDialog();
        }
    }
}