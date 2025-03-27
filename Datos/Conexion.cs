using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "BD_MINIMARKET";
            this.Servidor = "DESKTOP-73G3NEF";
            this.Usuario = ".";
            this.Clave = string.Empty;
            this.Seguridad = false;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();

            try
            {
                cadena.ConnectionString = @"Server=.;Database=BD_MINIMARKET;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";
                if (Seguridad == true)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integradet Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString+"User Id="+this.Usuario + "Password="+this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }

    }
}
