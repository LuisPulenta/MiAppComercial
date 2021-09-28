using CAD;
using System;
using System.Windows.Forms;

namespace Win.Consultas
{
    public partial class frmUnaCompra : Form
    {
        private CADUsuario usuarioLogueado;

        public CADUsuario UsuarioLogueado

        {
            get => usuarioLogueado;
            set => usuarioLogueado = value;
        }

        private int iDCompra;
        public int IDCompra

        {
            get => iDCompra;
            set => iDCompra = value;
        }

        private DateTime fecha;
        public DateTime Fecha

        {
            get => fecha;
            set => fecha = value;
        }

        private string proveedor;
        public string Proveedor

        {
            get => proveedor;
            set => proveedor = value;
        }

        private string almacen;
        public string Almacen

        {
            get => almacen;
            set => almacen = value;
        }

        public frmUnaCompra()
        {
            InitializeComponent();
        }

        private void frmUnaCompra_Load(object sender, EventArgs e)
        {
            iDCompraTextBox.Text = IDCompra.ToString();
            fechaTextBox.Text = Fecha.ToString();
            proveedorTextBox.Text = Proveedor;
            almacenTextBox.Text = Almacen;
        }
    }
}

