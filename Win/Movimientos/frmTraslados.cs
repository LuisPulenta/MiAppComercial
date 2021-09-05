using CAD;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Movimientos
{
    public partial class frmTraslados : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int totalItems = 0;
        List<DetalleTraslado> misDetalles = new List<DetalleTraslado>();
        CADProducto ultimoProducto = null;

        public frmTraslados()
        {
            InitializeComponent();
        }

        private void frmTraslados_Load(object sender, EventArgs e)
        {
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            almacenOrigenComboBox.SelectedIndex = -1;
            almacenDestinoComboBox.SelectedIndex = -1;
            productoLabel.Text = string.Empty;
        }

        private void productoTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.Clear();
            pbxImagen.Image = null;
            if (productoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Código de Producto o un Código de Barras");
                return;
            }

            string producto = productoTextBox.Text;

            long barra;

            try
            {
                long.TryParse(productoTextBox.Text, out barra);
            }
            catch (Exception)
            {
                barra = 0;
            }

            CADProducto miProducto = CADProducto.ProductoGetProductoByCodigo((string)producto);
            if (miProducto == null)
            {
                miProducto = CADProducto.ProductoGetProductoByIDBarra(barra);
            }
            if (miProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Producto no existe");
                productoLabel.Text = string.Empty;
                pbxImagen.Image = null;
                ultimoProducto = null;
            }
            else
            {
                productoLabel.Text = miProducto.Descripcion;
                ultimoProducto = miProducto;
                if (miProducto.Imagen == string.Empty)
                {
                    pbxImagen.Image = null;
                }
                else
                {

                    if (File.Exists("Images\\" + miProducto.Imagen))
                    {
                        if (miProducto.Imagen == string.Empty)
                        {
                            pbxImagen.Image = null;
                        }
                        else
                        {
                            if (File.Exists("Images\\" + miProducto.Imagen))
                            {
                                pbxImagen.Load("Images\\" + miProducto.Imagen);
                            }
                        }
                    }
                    else
                    {
                        pbxImagen.Image = null;
                    }
                }
                precioTextBox.Text = string.Format("{0:C2}", ultimoProducto.Precio);
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBusquedaProducto miBusqueda = new frmBusquedaProducto();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == "") return;
            productoTextBox.Text = miBusqueda.IDElegido.ToString();
            productoTextBox_Validating(sender, new System.ComponentModel.CancelEventArgs());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarLineaButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;
            if (dgvDatos.SelectedRows.Count == 0)
            {
                misDetalles.RemoveAt(misDetalles.Count - 1);
                RefrescaGrid();
            }
            else
            {
                string Codigo = (string)dgvDatos.SelectedRows[0].Cells[0].Value;
                for (int i = 0; i < misDetalles.Count; i++)
                {
                    if (misDetalles[i].Codigo == Codigo)
                    {
                        misDetalles.RemoveAt(i);
                        break;
                    }
                }
            }
            RefrescaGrid();
        }

        private void eliminarTodoButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDetalles.Count == 0) return;

            DialogResult rta = MessageBox.Show(
             "¿Está seguro de borrar todas las líneas del Traslado?",
             "Confirmación",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            misDetalles.Clear();

            totalItems = 0;
            RefrescaGrid();
            pbxImagen.Image = null;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (ultimoProducto == null)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar un Producto");
                productoTextBox.Focus();
                return;
            }
            if (cantidadTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar una Cantidad");
                return;
            }

            float cantidad;
            if (!float.TryParse(cantidadTextBox.Text, out cantidad))
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor numérico");
                cantidadTextBox.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                errorProvider1.SetError(cantidadTextBox, "Debe ingresar un valor mayor a 0");
                cantidadTextBox.Focus();
                return;
            }

            decimal precio = ultimoProducto.Precio;

            DetalleTraslado miDetalle = new DetalleTraslado();
            miDetalle.Cantidad = cantidad;
            miDetalle.Precio = precio;
            miDetalle.Descripcion = ultimoProducto.Descripcion;
            miDetalle.Codigo = ultimoProducto.Codigo;
            miDetalle.PorcentajeIVA = CADIVA.IVAGetIVAByIDIVA(ultimoProducto.IDIVA).Tarifa;

            misDetalles.Add(miDetalle);

            pbxImagen.Image = null;

            RefrescaGrid();

            LimpiarControles();
        }

        private void LimpiarControles()
        {
            ultimoProducto = null;
            productoTextBox.Text = string.Empty;
            productoLabel.Text = string.Empty;
            cantidadTextBox.Text = string.Empty;
            precioTextBox.Text = string.Empty;
            productoTextBox.Focus();
        }

        private void RefrescaGrid()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = misDetalles;

            totalItems = 0;


            foreach (DetalleTraslado miDetalle in misDetalles)
            {
                totalItems += 1;
            }

            totalItemTextBox.Text = string.Format("{0:N0}", totalItems);

            PersonalizaGrid();
        }

        private void PersonalizaGrid()
        {
            dgvDatos.Columns["Codigo"].HeaderText = "Código";
            dgvDatos.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatos.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatos.Columns["Precio"].HeaderText = "Precio";
            dgvDatos.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Precio"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["Cantidad"].DefaultCellStyle.Format = "N2";

            dgvDatos.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            dgvDatos.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";

            dgvDatos.Columns["ValorBruto"].HeaderText = "Valor Bruto";
            dgvDatos.Columns["ValorBruto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["ValorBruto"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["ValorIVA"].HeaderText = "Valor IVA";
            dgvDatos.Columns["ValorIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["ValorIVA"].DefaultCellStyle.Format = "C2";

            dgvDatos.Columns["ValorNeto"].HeaderText = "Valor Neto";
            dgvDatos.Columns["ValorNeto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatos.Columns["ValorNeto"].DefaultCellStyle.Format = "C2";

            //dgvDatos.AutoResizeColumns();

            dgvDatos.Columns["Codigo"].Width = 80;
            dgvDatos.Columns["Descripcion"].Width = 200;
            dgvDatos.Columns["Cantidad"].Width = 80;
            dgvDatos.Columns["Precio"].Width = 80;
            dgvDatos.Columns["PorcentajeIVA"].Width = 80;
            dgvDatos.Columns["ValorBruto"].Width = 80;
            dgvDatos.Columns["ValorIVA"].Width = 80;
            dgvDatos.Columns["ValorNeto"].Width = 80;
        }

        private void frmTraslados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (misDetalles.Count > 0)
            {
                DialogResult rta = MessageBox.Show(
            "El Traslado tiene productos cargados, ¿está seguro de salir sin terminar el Traslado?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

                if (rta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (almacenOrigenComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(almacenOrigenComboBox, "Debe seleccionar un Almacén Origen");
                almacenOrigenComboBox.Focus();
                return;
            }

            if (almacenDestinoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(almacenDestinoComboBox, "Debe seleccionar un Almacén Destino");
                almacenDestinoComboBox.Focus();
                return;
            }

            if (misDetalles.Count == 0)
            {
                errorProvider1.SetError(productoTextBox, "Debe ingresar al menos un Producto");
                productoTextBox.Focus();
                return;
            }

            DialogResult rta = MessageBox.Show(
            "¿Está seguro de guardar el Traslado?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int IDAlmacenOrigen = (int)almacenOrigenComboBox.SelectedValue;
            int IDAlmacenDestino = (int)almacenDestinoComboBox.SelectedValue;
            DateTime fecha = fechaDateTimePicker.Value;

            //Grabamos la Cabecera del Traslado
            int IDTraslado = CADTraslado.TrasladoInsertTraslado(
                fecha,
                IDAlmacenOrigen,
                IDAlmacenDestino);

            //Grabamos el Detalle del Traslado
            foreach (DetalleTraslado midetalle in misDetalles)
            {
                //Actualizamos la Tabla BodegaProducto
                CADAlmacenProducto miAlmacenProductoOrigen = CADAlmacenProducto.AlmacenProductoGetAlmacenProductoByIDAlmacenAndCodigo(IDAlmacenOrigen, midetalle.Codigo);

                if (miAlmacenProductoOrigen == null)
                {
                    CADAlmacenProducto.AlmacenProductoUpdate(IDAlmacenOrigen, midetalle.Codigo, 1, 1, 1, 1);

                }
                CADAlmacenProducto.AlmacenProductoActualizaStock(-midetalle.Cantidad, IDAlmacenOrigen, midetalle.Codigo);

                CADAlmacenProducto miBodegaProductoDestino = CADAlmacenProducto.AlmacenProductoGetAlmacenProductoByIDAlmacenAndCodigo(IDAlmacenDestino, midetalle.Codigo);

                if (miBodegaProductoDestino == null)
                {
                    CADAlmacenProducto.AlmacenProductoUpdate(IDAlmacenDestino, midetalle.Codigo, 1, 1, 1, 1);

                }
                CADAlmacenProducto.AlmacenProductoActualizaStock(midetalle.Cantidad, IDAlmacenDestino, midetalle.Codigo);


                //Actualizamos el Kardex
                CADKardex miKardexOrigen = CADKardex.KardexUltimoKardex(IDAlmacenOrigen, midetalle.Codigo);

                int IDKardexOrigen;
                float nuevoSaldoOrigen;
                decimal nuevoCostoPromedioOrigen;
                decimal nuevoUltimoCostoOrigen;

                if (miKardexOrigen == null)
                {
                    nuevoSaldoOrigen = -midetalle.Cantidad;
                    nuevoCostoPromedioOrigen = 0;
                    nuevoUltimoCostoOrigen = 0;
                }
                else
                {
                    nuevoSaldoOrigen = miKardexOrigen.Saldo - midetalle.Cantidad;
                    nuevoCostoPromedioOrigen = miKardexOrigen.CostoPromedio;
                    nuevoUltimoCostoOrigen = miKardexOrigen.UltimoCosto;
                }

                IDKardexOrigen = CADKardex.KardexInsert(
                        IDAlmacenOrigen,
                        midetalle.Codigo,
                        fecha,
                        string.Format("TR-{0}", IDTraslado),
                        0,
                        midetalle.Cantidad,
                        nuevoSaldoOrigen,
                        nuevoUltimoCostoOrigen,
                        nuevoCostoPromedioOrigen);

                CADKardex miKardexDestino = CADKardex.KardexUltimoKardex(IDAlmacenDestino, midetalle.Codigo);

                int IDKardexDestino;
                float nuevoSaldoDestino;
                decimal nuevoCostoPromedioDestino;
                decimal nuevoUltimoCostoDestino;

                if (miKardexDestino == null)
                {
                    nuevoSaldoDestino = midetalle.Cantidad;
                    nuevoCostoPromedioDestino = 0;
                    nuevoUltimoCostoDestino = 0;
                }
                else
                {
                    nuevoSaldoDestino = miKardexDestino.Saldo + midetalle.Cantidad;
                    nuevoCostoPromedioDestino = miKardexDestino.CostoPromedio;
                    nuevoUltimoCostoDestino = miKardexDestino.UltimoCosto;
                }

                IDKardexDestino = CADKardex.KardexInsert(
                        IDAlmacenDestino,
                        midetalle.Codigo,
                        fecha,
                        string.Format("TR-{0}", IDTraslado),
                        midetalle.Cantidad,
                        0,
                        nuevoSaldoDestino,
                        nuevoUltimoCostoDestino,
                        nuevoCostoPromedioDestino);


                //Actualizamos TrasladoDetalle
                CADTrasladoDetalle.TrasladoDetalleInsert(
                    IDTraslado,
                    midetalle.Codigo,
                    midetalle.Descripcion,
                    midetalle.Cantidad,
                    IDKardexOrigen,
                    IDKardexDestino);
            }

            MessageBox.Show(
                string.Format("El Traslado {0}, fue grabado de forma exitosa", IDTraslado),
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            totalItems = 0;
            pbxImagen.Image = null;

            almacenOrigenComboBox.SelectedIndex = -1;
            almacenDestinoComboBox.SelectedIndex = -1;
            misDetalles.Clear();
            pbxImagen.Image = null;
            RefrescaGrid();
            fechaDateTimePicker.Value = DateTime.Now;
            almacenOrigenComboBox.Focus();
        }
    }
}