using CAD.DSMiAppComercialTableAdapters;
using System;

namespace CAD
{
    public class CADUsuario
    {
        public string IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Clave { get; set; }
        public DateTime FechaModificacionClave { get; set; }
        public int IDRol { get; set; }
        public string Correo { get; set; }

        private static UsuarioTableAdapter adaptador = new UsuarioTableAdapter();

        public static bool ValidaUsuario(string IDUsuario, string Clave)
        {
            if (adaptador.UsuarioValida(IDUsuario, Clave) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool UsuarioExiste(string IDUsuario)
        {
            if (adaptador.UsuarioExiste(IDUsuario) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static CADUsuario UsuarioGetUsuarioByIDUsuario(string IDUsuario)
        {
            CADUsuario miUsuario = null;
            DSMiAppComercial.UsuarioDataTable miTabla = adaptador.UsuarioGetUsuarioByIDUsuario(IDUsuario);
            if (miTabla.Rows.Count == 0)
            {
                return miUsuario;
            }
            else
            {
                DSMiAppComercial.UsuarioRow miRegistro = (DSMiAppComercial.UsuarioRow)miTabla.Rows[0];
                miUsuario = new CADUsuario();
                miUsuario.Apellido = miRegistro.Apellido;
                miUsuario.Clave = miRegistro.Clave;
                miUsuario.Correo = miRegistro.Correo;
                miUsuario.FechaModificacionClave = miRegistro.FechaModificacionClave;
                miUsuario.IDRol = miRegistro.IDRol;
                miUsuario.IDUsuario = miRegistro.IDUsuario;
                miUsuario.Nombre = miRegistro.Nombre;

                return miUsuario;
            }
        }

        public static void UsuarioUpdateClave(
            string Clave,
            string IDUsuario
            )
        {
            adaptador.UsuarioUpdateClave(Clave, DateTime.Now, IDUsuario);
        }

    }
}