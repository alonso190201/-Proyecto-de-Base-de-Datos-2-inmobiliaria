using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Build.Framework.XamlTypes;


namespace Datos
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
            this.BD = "dbinmobiliaria";
            this.Server = "DESKTOP-BGVPBF6";// puede ser nombre de equipo (local o remoto) //ip /localhost
            this.User = "sa";
            this.Clave = "123";
            this.Autenticacion = false; //windows.
        }

        public SqlConnection Establecerconexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Server + ";" + "Database=" + this.BD + ";";
                if (this.Autenticacion)//seguridad de windows es true
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security=SSPI";
                }
                else//seguridad sql
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.User + ";" + "Password=" + this.Clave;
                }

            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion GetInstancia()
        {
            if (cnx == null)
            {
                cnx = new Conexion();
            }
            return cnx;
        }
    }
}
