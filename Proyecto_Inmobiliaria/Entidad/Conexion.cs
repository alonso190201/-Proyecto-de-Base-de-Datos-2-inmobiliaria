using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidad
{
    class Conexion
    {
        private string BD;
        private string Server;
        private string User;
        private string Clave;
        private bool Autenticacion;
        private static Conexion cnx = null;

        private Conexion()
        {
            this.BD = "db_sistema1";
            this.Server = "DESKTOP-BGVPBF6"; //nombre del equipo (local/remoto) //IP /localhost
            this.User = "sa";
            this.Clave = "123";
            this.Autenticacion = false; //Windows
        }

        public SqlConnection EstablecerConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Server + ";" + "Database=" + this.BD + ";";

                if (this.Autenticacion) //seguridad windows true
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else //Seguridad sql
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id" + this.User + ";" + "Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getIntancia()
        {
            if (cnx == null)
            {
                cnx = new Conexion();
            }
            return cnx;
        }
    }
}
