using CAD;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Win.Busqueda;
using Win.Clases;

namespace Win.Movimientos
{
    public partial class frmDevolucionClientes : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado
        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private List<DevolucionClienteDisponible> misDisponibles = new List<DevolucionClienteDisponible>();
        private List<DevolucionClienteDevuelto> misDevueltos = new List<DevolucionClienteDevuelto>();

        public frmDevolucionClientes()
        {
            InitializeComponent();
        }

        private void frmDevolucionClientes_Load(object sender, EventArgs e)
        {
            this.almacenTableAdapter.Fill(this.dSMiAppComercial.Almacen);
            this.clienteTableAdapter.Fill(this.dSMiAppComercial.Cliente);
            this.productoTableAdapter.Fill(this.dSMiAppComercial.Producto);
            this.ventaTableAdapter.Fill(this.dSMiAppComercial.Venta);
            ventaTextBox.Text = String.Empty;
            clienteComboBox.SelectedIndex = -1;
            almacenComboBox.SelectedIndex = -1;
            productoComboBox.SelectedIndex = -1;
            fechaDevolucionDateTimePicker.Value = DateTime.Now;
            dgvDatosDisponible.DataSource = misDisponibles;
            //dgvDatosDevuelto.DataSource = misDevueltos;
            PersonalizarDisponibles();
            //PersonalizarDevueltos();
        }

        private void PersonalizarDisponibles()
        {
            dgvDatosDisponible.Columns["Codigo"].HeaderText = "Código";
            dgvDatosDisponible.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatosDisponible.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatosDisponible.Columns["Precio"].HeaderText = "Precio";
            dgvDatosDisponible.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["Precio"].DefaultCellStyle.Format = "C2";

            dgvDatosDisponible.Columns["CantidadOriginal"].HeaderText = "Cant. Orig.";
            dgvDatosDisponible.Columns["CantidadOriginal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadOriginal"].DefaultCellStyle.Format = "N2";

            dgvDatosDisponible.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            dgvDatosDisponible.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";

            dgvDatosDisponible.Columns["PorcentajeDescuento"].HeaderText = "% Descuento";
            dgvDatosDisponible.Columns["PorcentajeDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["PorcentajeDescuento"].DefaultCellStyle.Format = "P2";

            dgvDatosDisponible.Columns["CantidadDevuelta"].HeaderText = "Cant. Dev.";
            dgvDatosDisponible.Columns["CantidadDevuelta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadDevuelta"].DefaultCellStyle.Format = "N2";

            dgvDatosDisponible.Columns["CantidadDisponible"].HeaderText = "Cant. Disp.";
            dgvDatosDisponible.Columns["CantidadDisponible"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDisponible.Columns["CantidadDisponible"].DefaultCellStyle.Format = "N2";

            dgvDatosDisponible.Columns["Codigo"].Width = 80;
            dgvDatosDisponible.Columns["Descripcion"].Width = 200;
            dgvDatosDisponible.Columns["CantidadOriginal"].Width = 80;
            dgvDatosDisponible.Columns["Precio"].Width = 80;
            dgvDatosDisponible.Columns["PorcentajeIVA"].Width = 80;
            dgvDatosDisponible.Columns["PorcentajeDescuento"].Width = 80;
            dgvDatosDisponible.Columns["CantidadDevuelta"].Width = 80;
            dgvDatosDisponible.Columns["CantidadDisponible"].Width = 80;
        }

        private void PersonalizarDevueltos()
        {
            dgvDatosDevuelto.Columns["Codigo"].HeaderText = "Código";
            dgvDatosDevuelto.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDatosDevuelto.Columns["Descripcion"].HeaderText = "Descripción";

            dgvDatosDevuelto.Columns["Precio"].HeaderText = "Precio";
            dgvDatosDevuelto.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDevuelto.Columns["Precio"].DefaultCellStyle.Format = "C2";

            dgvDatosDevuelto.Columns["CantidadADevolver"].HeaderText = "Cant. a devolver.";
            dgvDatosDevuelto.Columns["CantidadADevolver"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDevuelto.Columns["CantidadADevolver"].DefaultCellStyle.Format = "N2";

            dgvDatosDevuelto.Columns["PorcentajeIVA"].HeaderText = "% IVA";
            dgvDatosDevuelto.Columns["PorcentajeIVA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDevuelto.Columns["PorcentajeIVA"].DefaultCellStyle.Format = "P2";

            dgvDatosDevuelto.Columns["PorcentajeDescuento"].HeaderText = "% Descuento";
            dgvDatosDevuelto.Columns["PorcentajeDescuento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDatosDevuelto.Columns["PorcentajeDescuento"].DefaultCellStyle.Format = "P2";

            dgvDatosDevuelto.Columns["Codigo"].Width = 80;
            dgvDatosDevuelto.Columns["Descripcion"].Width = 200;
            dgvDatosDevuelto.Columns["CantidadADevolver"].Width = 80;
            dgvDatosDevuelto.Columns["Precio"].Width = 80;
            dgvDatosDevuelto.Columns["PorcentajeIVA"].Width = 80;
            dgvDatosDevuelto.Columns["PorcentajeDescuento"].Width = 80;
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (productoComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(productoComboBox, "Debe seleccionar un Producto");
                productoComboBox.Focus();
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

            if (cantidad > misDisponibles[productoComboBox.SelectedIndex].CantidadDisponible)
            {
                errorProvider1.SetError(cantidadTextBox, "La cantidad a devolver no puede ser mayor a la disponible");
                cantidadTextBox.Focus();
                return;
            }

            foreach (DevolucionClienteDevuelto nuevoDevuelto in misDevueltos)
            {
                if ((string)productoComboBox.SelectedValue == nuevoDevuelto.Codigo)
                {
                    errorProvider1.SetError(productoComboBox, "El Producto ya fue agregado a la devolución");
                    productoComboBox.Focus();
                    return;
                }
            }

            DevolucionClienteDevuelto miDevuelto = new DevolucionClienteDevuelto();
            miDevuelto.CantidadADevolver = cantidad;
            miDevuelto.Descripcion = misDisponibles[productoComboBox.SelectedIndex].Descripcion;
            miDevuelto.Codigo = misDisponibles[productoComboBox.SelectedIndex].Codigo;
            miDevuelto.PorcentajeDescuento = misDisponibles[productoComboBox.SelectedIndex].PorcentajeDescuento;
            miDevuelto.PorcentajeIVA = misDisponibles[productoComboBox.SelectedIndex].PorcentajeIVA;
            miDevuelto.Precio = misDisponibles[productoComboBox.SelectedIndex].Precio;
            misDevueltos.Add(miDevuelto);

            productoComboBox.SelectedIndex = -1;
            cantidadTextBox.Text = string.Empty;
            productoComboBox.Focus();

            dgvDatosDevuelto.DataSource = null;
            dgvDatosDevuelto.DataSource = misDevueltos;
            PersonalizarDevueltos();
        }

        private void btnDevolverTodo_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(
             "¿Está seguro de agregar todos los ítems de la venta original a la Devolución?",
             "Confirmación",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            misDevueltos.Clear();
            foreach (DevolucionClienteDisponible miDisponible in misDisponibles)
            {
                if (miDisponible.CantidadDisponible > 0)
                {
                    DevolucionClienteDevuelto miDevuelto = new DevolucionClienteDevuelto();
                    miDevuelto.CantidadADevolver = miDisponible.CantidadDisponible;
                    miDevuelto.Descripcion = miDisponible.Descripcion;
                    miDevuelto.Codigo = miDisponible.Codigo;
                    miDevuelto.PorcentajeDescuento = miDisponible.PorcentajeDescuento;
                    miDevuelto.PorcentajeIVA = miDisponible.PorcentajeIVA;
                    miDevuelto.Precio = miDisponible.Precio;
                    misDevueltos.Add(miDevuelto);
                }
            }
            RefrescarDevueltos();
            PersonalizarDevueltos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ventaTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ventaTextBox, "Debe seleccionar una Venta");
                ventaTextBox.Focus();
                return;
            }

            if (misDevueltos.Count == 0)
            {
                errorProvider1.SetError(productoComboBox, "Debe ingresar al menos un Producto en la Devolución");
                productoComboBox.Focus();
                return;
            }

            DialogResult rta = MessageBox.Show(
            "¿Está seguro de guardar la Devolución de Cliente?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            int IDVenta = Convert.ToInt32(ventaTextBox.Text);
            int IDAlmacen = (int)almacenComboBox.SelectedValue;
            DateTime fecha = fechaDevolucionDateTimePicker.Value;

            //Grabamos la Cabecera de la Devolución
            int IDDevolucion = CADDevolucionCliente.DevolucionClienteInsert(fecha, IDVenta);

            //Grabamos el Detalle de la Devolución
            foreach (DevolucionClienteDevuelto midevuelto in misDevueltos)
            {
                //Actualizamos la Tabla BodegaProducto
                CADAlmacenProducto miAlmacenProducto = CADAlmacenProducto.AlmacenProductoGetAlmacenProductoByIDAlmacenAndCodigo(IDAlmacen, midevuelto.Codigo);

                if (miAlmacenProducto == null)
                {
                    CADAlmacenProducto.AlmacenProductoUpdate(IDAlmacen, midevuelto.Codigo, 1, 1, 1, 1);

                }
                CADAlmacenProducto.AlmacenProductoActualizaStock(midevuelto.CantidadADevolver, IDAlmacen, midevuelto.Codigo);

                //Actualizamos el Kardex
                CADKardex miKardex = CADKardex.KardexUltimoKardex(IDAlmacen, midevuelto.Codigo);

                int IDKardex;
                float nuevoSaldo;
                decimal nuevoCostoPromedio;
                decimal nuevoUltimoCosto;

                if (miKardex == null)
                {
                    nuevoSaldo = midevuelto.CantidadADevolver;
                    nuevoCostoPromedio = midevuelto.Precio;
                    nuevoUltimoCosto = nuevoCostoPromedio;
                }
                else
                {
                    nuevoSaldo = miKardex.Saldo + midevuelto.CantidadADevolver;
                    if (nuevoSaldo != 0)
                    {
                        nuevoCostoPromedio = (miKardex.CostoPromedio * (decimal)miKardex.Saldo
                        + midevuelto.Precio * (decimal)midevuelto.CantidadADevolver) / (decimal)nuevoSaldo;
                    }
                    else
                    {
                        nuevoCostoPromedio = 0;
                    }
                    nuevoUltimoCosto = (decimal)midevuelto.Precio;
                }

                IDKardex = CADKardex.KardexInsert(
                        IDAlmacen,
                        midevuelto.Codigo,
                        fecha,
                        string.Format("DC-{0}", IDDevolucion),
                        midevuelto.CantidadADevolver,
                        0,
                        nuevoSaldo,
                        nuevoUltimoCosto,
                        nuevoCostoPromedio);

                //Actualizamos DevolcuionVentaDetalle
                CADDevolucionClienteDetalle.DevolucionClienteDetalleInsert(
                    IDDevolucion,
                    midevuelto.Codigo,
                    midevuelto.Descripcion,
                    midevuelto.Precio,
                    midevuelto.CantidadADevolver,
                    IDKardex,
                    midevuelto.PorcentajeIVA,
                    midevuelto.PorcentajeDescuento)
                    ;
            }

            MessageBox.Show(
                string.Format("La Devolución de Cliente {0}, fue grabada de forma exitosa", IDDevolucion),
                "Confirmación",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ventaTextBox.Text = String.Empty;
            almacenComboBox.SelectedIndex = -1;
            clienteComboBox.SelectedIndex = -1;
            fechaDevolucionDateTimePicker.Value = DateTime.Now;
            fechaTextBox.Text = string.Empty;
            productoComboBox.SelectedIndex = -1;

            misDisponibles.Clear();
            misDevueltos.Clear();

            dgvDatosDisponible.DataSource = null;
            dgvDatosDevuelto.DataSource = null;

            dgvDatosDisponible.DataSource = misDisponibles;
            dgvDatosDevuelto.DataSource = misDevueltos;

            PersonalizarDisponibles();
            PersonalizarDevueltos();

            ventaTextBox.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarLineaButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDevueltos.Count == 0) return;
            if (dgvDatosDevuelto.SelectedRows.Count == 0)
            {
                misDevueltos.RemoveAt(misDevueltos.Count - 1);
                RefrescarDevueltos();
            }
            else
            {
                string Codigo = (string)dgvDatosDevuelto.SelectedRows[0].Cells[0].Value;
                for (int i = 0; i < misDevueltos.Count; i++)
                {
                    if (misDevueltos[i].Codigo == Codigo)
                    {
                        misDevueltos.RemoveAt(i);
                        break;
                    }
                }
            }
            RefrescarDevueltos();
            PersonalizarDevueltos();
        }

        private void eliminarTodoButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (misDevueltos.Count == 0) return;

            DialogResult rta = MessageBox.Show(
             "¿Está seguro de borrar el todas las líneas de la Devolución?",
             "Confirmación",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.No) return;

            misDevueltos.Clear();
            RefrescarDevueltos();
            PersonalizarDevueltos();
        }

        private void RefrescarDevueltos()
        {
            dgvDatosDevuelto.DataSource = null;
            dgvDatosDevuelto.DataSource = misDevueltos;
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            frmBusquedaVentas miBusqueda = new frmBusquedaVentas();
            miBusqueda.ShowDialog();
            if (miBusqueda.IDElegido == 0) return;
            ventaTextBox.Text = miBusqueda.IDElegido.ToString();
            ventaTextBox.Focus();
            productoComboBox.Focus();
        }

        private void ventaTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (ventaTextBox.Text == string.Empty) return;
            CADVenta miVenta = CADVenta.VentasGetVentaByIDVenta(Convert.ToInt32(ventaTextBox.Text));
            if (miVenta == null)
            {
                fechaTextBox.Text = string.Empty;
                clienteComboBox.SelectedIndex = -1;
                almacenComboBox.SelectedIndex = -1;
                misDisponibles.Clear();
                misDevueltos.Clear();
                dgvDatosDisponible.DataSource = null;
                dgvDatosDevuelto.DataSource = null;
                dgvDatosDisponible.DataSource = misDisponibles;
                dgvDatosDevuelto.DataSource = misDevueltos;
                PersonalizarDisponibles();
                PersonalizarDevueltos();
                errorProvider1.SetError(ventaTextBox, "No existe esta Venta");
                return;
            }
            fechaTextBox.Text = miVenta.Fecha.ToString();
            clienteComboBox.SelectedValue = miVenta.IDCliente;
            almacenComboBox.SelectedValue = miVenta.IDAlmacen;
            misDisponibles.Clear();
            misDevueltos.Clear();
            productoComboBox.SelectedIndex = -1;

            CAD.DSMiAppComercial.VentaDetalleDataTable miTabla = CADVentaDetalle.VentaDetalleGetVentaDetalleByIDVenta(miVenta.IDVenta);
            foreach (CAD.DSMiAppComercial.VentaDetalleRow miRegistro in miTabla.Rows)
            {
                DevolucionClienteDisponible miDisponible = new DevolucionClienteDisponible();
                miDisponible.CantidadDevuelta = (float)CADDevolucionClienteDetalle.DevolucionClienteGetHistoria(miRegistro.IDVenta, miRegistro.Codigo);
                miDisponible.CantidadOriginal = (float)miRegistro.Cantidad;
                miDisponible.Descripcion = miRegistro.Descripcion;
                miDisponible.Codigo = miRegistro.Codigo;
                miDisponible.PorcentajeDescuento = (float)miRegistro.PorcentajeDescuento;
                miDisponible.PorcentajeIVA = (float)miRegistro.PorcentajeIVA;
                miDisponible.Precio = miRegistro.Precio;
                misDisponibles.Add(miDisponible);
            }
            dgvDatosDisponible.DataSource = null;
            dgvDatosDisponible.DataSource = misDisponibles;
            PersonalizarDisponibles();
            //PersonalizarDevueltos();

            productoComboBox.DataSource = null;
            productoComboBox.DataSource = misDisponibles;
            productoComboBox.DisplayMember = "Descripcion";
            productoComboBox.ValueMember = "Codigo";
            productoComboBox.SelectedIndex = -1;

            dgvDatosDisponible.AutoResizeColumns();
        }
    }
}