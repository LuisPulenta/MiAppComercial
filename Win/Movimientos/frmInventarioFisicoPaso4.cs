using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Clases;
using Win.Listados;

namespace Win.Movimientos
{
    public partial class frmInventarioFisicoPaso4 : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private List<MaterialAContar> misMaterialesAContar = new List<MaterialAContar>();

        public frmInventarioFisicoPaso4()
        {
            InitializeComponent();
        }

        private void frmInventarioFisicoPaso4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSMiAppComercial.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill3(this.dSMiAppComercial.Inventario);
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

            CAD.DSMiAppComercial.MaterialAContarDataTable miTabla = CADMaterialAContar.GetData3(InventarioID);
            foreach (CAD.DSMiAppComercial.MaterialAContarRow miRegistro in miTabla.Rows)
            {
                MaterialAContar miMaterialAContar = new MaterialAContar();
                miMaterialAContar.IDLinea = (int)miRegistro.IDLinea;
                miMaterialAContar.Codigo = miRegistro.Codigo;
                miMaterialAContar.Descripcion = miRegistro.Descripcion;
                miMaterialAContar.Unidad = miRegistro.Unidad;
                miMaterialAContar.Medida = (int)miRegistro.Medida;
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
            dgvDatos.Columns["Conteo1"].ReadOnly = true;

            dgvDatos.Columns["Conteo2"].HeaderText = "Conteo 2";
            dgvDatos.Columns["Conteo2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Conteo2"].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns["Conteo2"].ReadOnly = true;
            dgvDatos.Columns["Conteo2"].Visible = true;

            dgvDatos.Columns["Conteo3"].HeaderText = "Conteo 3";
            dgvDatos.Columns["Conteo3"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Conteo3"].DefaultCellStyle.Format = "N2";
            dgvDatos.Columns["Conteo3"].ReadOnly = false;
            dgvDatos.Columns["Conteo3"].Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
          "¿Está seguro de guardar el Tercer Conteo y hacer los Ajustes Finales?",
          "Confirmación",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Question,
          MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No)
            {
                return;
            }

            DateTime fecha = DateTime.Now;
            int IDInventario = (int) IDInventarioComboBox.SelectedValue;
            int IDAlmacen = CADInventario.InventarioGetIDAlmacenByIDInventario((int)IDInventarioComboBox.SelectedValue);

            foreach (MaterialAContar miMaterialAContar in misMaterialesAContar)
            {

                if (miMaterialAContar.Conteo3 != miMaterialAContar.Stock && miMaterialAContar.Conteo1 != miMaterialAContar.Stock && miMaterialAContar.Conteo2 != miMaterialAContar.Stock)
                {

                    //Actualizamos la Tabla BodegaProducto
                    CADAlmacenProducto miAlmacenProducto = CADAlmacenProducto.AlmacenProductoGetAlmacenProductoByIDAlmacenAndCodigo(IDAlmacen, miMaterialAContar.Codigo);

                    if (miAlmacenProducto == null)
                    {
                        CADAlmacenProducto.AlmacenProductoUpdate(IDAlmacen, miMaterialAContar.Codigo, 1, 1, 1, 1);

                    }
                    CADAlmacenProducto.AlmacenProductoActualizaStock((float) miMaterialAContar.Conteo3, IDAlmacen, miMaterialAContar.Codigo);

                    //Actualizamos el Kardex
                    CADKardex miKardex = CADKardex.KardexUltimoKardex(IDAlmacen, miMaterialAContar.Codigo);

                    int IDKardex;
                    float nuevoSaldo;
                    decimal nuevoCostoPromedio;
                    decimal nuevoUltimoCosto;

                    if (miKardex == null)
                    {
                        nuevoSaldo = (float)miMaterialAContar.Conteo3;
                        nuevoCostoPromedio = 0;
                        nuevoUltimoCosto = 0;
                    }
                    else
                    {
                        nuevoSaldo = (float)miMaterialAContar.Conteo3;
                        nuevoCostoPromedio = miKardex.CostoPromedio;
                        nuevoUltimoCosto = miKardex.UltimoCosto;
                    }

                    if(miMaterialAContar.Conteo3 > miMaterialAContar.Stock)
                    {
                        IDKardex = CADKardex.KardexInsert(
                            IDAlmacen,
                            miMaterialAContar.Codigo,
                            fecha,
                            string.Format("AI-{0}", IDInventario),
                            (float) miMaterialAContar.Conteo3 - (float) miMaterialAContar.Stock,
                            0,
                            nuevoSaldo,
                            nuevoUltimoCosto,
                            nuevoCostoPromedio);
                    }
                    else
                    {
                        IDKardex = CADKardex.KardexInsert(
                           IDAlmacen,
                           miMaterialAContar.Codigo,
                           fecha,
                           string.Format("AI-{0}", IDInventario),
                           0,
                           (float) miMaterialAContar.Stock - (float) miMaterialAContar.Conteo3,
                           nuevoSaldo,
                           nuevoUltimoCosto,
                           nuevoCostoPromedio);
                    }
                    var A = 1;
                    
                    CADInventarioDetalle.InventarioDetalleUpDateConteo3(miMaterialAContar.Conteo3, miMaterialAContar.Conteo3 - miMaterialAContar.Stock, IDKardex, miMaterialAContar.IDLinea);
                }
            }

            CADInventario.InventarioUpDatePaso(4, (int)IDInventarioComboBox.SelectedValue);

            MessageBox.Show(
                string.Format("El Conteo 3 fue grabado de forma exitosa y se hizo el Ajuste {0}.",IDInventario),
                "Aviso!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (IDInventarioComboBox.SelectedIndex == -1)
            {
                return;
            }
            frmConteo3 frm = new frmConteo3();
            frm.IdInventario = Convert.ToInt32(IDInventarioComboBox.SelectedValue);
            frm.ShowDialog();
        }
    }
}
