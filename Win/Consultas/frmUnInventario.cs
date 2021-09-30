using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Clases;

namespace Win.Consultas
{
    public partial class frmUnInventario : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int iDInventario;
        public int IDInventario

        {
            get => iDInventario;
            set => iDInventario = value;
        }

        private DateTime fecha;
        public DateTime Fecha

        {
            get => fecha;
            set => fecha = value;
        }

        private string categoria;
        public string Categoria

        {
            get => categoria;
            set => categoria = value;
        }

        private string almacen;
        public string Almacen

        {
            get => almacen;
            set => almacen = value;
        }

        private List<MaterialAContar2> misDetalles = new List<MaterialAContar2>();

        private int totalItems = 0;
        private decimal totalSobranteUltimoCosto = 0;
        private decimal totalFaltanteUltimoCosto = 0;
        private decimal totalSobranteCostoPromedio = 0;
        private decimal totalFaltanteCostoPromedio = 0;

        public frmUnInventario()
        {
            InitializeComponent();
        }

        private void frmUnInventario_Load(object sender, EventArgs e)
        {
            iDInventarioTextBox.Text = IDInventario.ToString();
            fechaTextBox.Text = Fecha.ToString();
            categoriaTextBox.Text = Categoria;
            almacenTextBox.Text = Almacen;
            iDInventarioTextBox_Validating(sender, e);
        }

        private void iDInventarioTextBox_Validating(object sender, EventArgs e)
        {
            if (iDInventarioTextBox.Text == null) return;
            CADInventario miInventario = CADInventario.InventariosGetInventarioByIDInventario(Convert.ToInt32(iDInventarioTextBox.Text));
            if (miInventario == null)
            {
                fechaTextBox.Text = string.Empty;
                categoriaTextBox.Text = string.Empty;
                almacenTextBox.Text = string.Empty;
                misDetalles.Clear();
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = misDetalles;
                PersonalizarGrilla();
                errorProvider1.SetError(iDInventarioTextBox, "No existe este Inventario");
                return;
            }

            fechaTextBox.Text = miInventario.Fecha.ToString();
            categoriaTextBox.Text = Categoria;
            almacenTextBox.Text = Almacen;

            CAD.DSMiAppComercial.InventarioDetalle2DataTable miTabla = CADInventarioDetalle2.InventarioDetalleGetInventarioDetalleByIDInventario(miInventario.IDInventario);
            foreach (CAD.DSMiAppComercial.InventarioDetalle2Row miRegistro in miTabla.Rows)
            {
                MaterialAContar2 miDetalle = new MaterialAContar2();
                miDetalle.Codigo = miRegistro.Codigo;
                miDetalle.Descripcion = miRegistro.Descripcion;
                miDetalle.Unidad = miRegistro.Unidad;
                miDetalle.Medida = (int) miRegistro.Medida;
                miDetalle.Stock = (float)miRegistro.Stock;
                miDetalle.Conteo1 = (float)miRegistro.Conteo1;
                miDetalle.Conteo2 = (float)miRegistro.Conteo2;
                miDetalle.Conteo3 = (float)miRegistro.Conteo3;
                miDetalle.Ajuste = (float)miRegistro.Ajuste;
                miDetalle.valorFaltanteCostoPromedio = (decimal) miRegistro.FaltanteCostoPromedio;
                miDetalle.valorSobranteCostoPromedio = (decimal)miRegistro.SobranteCostoPromedio;
                miDetalle.valorFaltanteUltimoCosto = (decimal)miRegistro.FaltanteUltimoCosto;
                miDetalle.valorSobranteUltimoCosto = (decimal)miRegistro.SobranteUltimoCosto;
                

                misDetalles.Add(miDetalle);
            }
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;
            PersonalizarGrilla();
            dgvDatos.AutoResizeColumns();
        }

        private void PersonalizarGrilla()
        {
            dgvDatos.Columns["Codigo"].HeaderText = "Código";
            dgvDatos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatos.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatos.Columns["Unidad"].HeaderText = "Unidad";
            dgvDatos.Columns["Unidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatos.Columns["Medida"].HeaderText = "Medida";
            dgvDatos.Columns["Medida"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDatos.Columns["Medida"].DefaultCellStyle.Format = "N0";


            dgvDatos.Columns["UltimoCosto"].Visible = false;
            //dgvDatos.Columns["UltimoCosto"].HeaderText = "Último Costo";
            //dgvDatos.Columns["UltimoCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvDatos.Columns["UltimoCosto"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["CostoPromedio"].Visible = false;
            //dgvDatos.Columns["CostoPromedio"].HeaderText = "Costo Promedio";
            //dgvDatos.Columns["CostoPromedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvDatos.Columns["CostoPromedio"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["Stock"].HeaderText = "Stock";
            dgvDatos.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Stock"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["Conteo1"].HeaderText = "Conteo1";
            dgvDatos.Columns["Conteo1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Conteo1"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["Conteo2"].HeaderText = "Conteo2";
            dgvDatos.Columns["Conteo2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Conteo2"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["Conteo3"].HeaderText = "Conteo3";
            dgvDatos.Columns["Conteo3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Conteo3"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["Ajuste"].HeaderText = "Ajuste";
            dgvDatos.Columns["Ajuste"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Ajuste"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["valorSobranteUltimoCosto"].HeaderText = "Sobrante Último Costo";
            dgvDatos.Columns["valorSobranteUltimoCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorSobranteUltimoCosto"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["valorFaltanteUltimoCosto"].HeaderText = "Faltante Último Costo";
            dgvDatos.Columns["valorFaltanteUltimoCosto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorFaltanteUltimoCosto"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["valorSobranteCostoPromedio"].HeaderText = "Sobrante Costo Promedio";
            dgvDatos.Columns["valorSobranteCostoPromedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorSobranteCostoPromedio"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["valorFaltanteCostoPromedio"].HeaderText = "Faltante Costo Promedio";
            dgvDatos.Columns["valorFaltanteCostoPromedio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["valorFaltanteCostoPromedio"].DefaultCellStyle.Format = "C2";

            totalItems = 0;
            totalSobranteUltimoCosto = 0;
            totalFaltanteUltimoCosto = 0;
            totalSobranteCostoPromedio = 0;
            totalFaltanteCostoPromedio = 0;




            foreach (MaterialAContar2 miDetalle in misDetalles)
            {
                totalItems += 1;
                totalSobranteUltimoCosto += miDetalle.valorSobranteUltimoCosto;
                totalFaltanteUltimoCosto += miDetalle.valorFaltanteUltimoCosto;
                totalSobranteCostoPromedio += miDetalle.valorSobranteCostoPromedio;
                totalFaltanteCostoPromedio += miDetalle.valorFaltanteCostoPromedio;
            }

            totalItemsTextBox.Text = string.Format("{0:N0}", totalItems);
            totalSobranteUltimoCostoTextBox.Text = string.Format("{0:C2}", totalSobranteUltimoCosto);
            totalFaltanteUltimoCostoTextBox.Text = string.Format("{0:C2}", totalFaltanteUltimoCosto);
            totalSobranteCostoPromedioTextBox.Text = string.Format("{0:C2}", totalSobranteCostoPromedio);
            totalFaltanteCostoPromedioTextBox.Text = string.Format("{0:C2}", totalFaltanteCostoPromedio);
        }
    }
}