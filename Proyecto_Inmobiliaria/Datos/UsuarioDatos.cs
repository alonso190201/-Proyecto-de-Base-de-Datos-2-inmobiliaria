using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using SistemaEscritorio.Entidad;
using Entidad;

namespace Datos
{
    public class UsuarioDatos
    {
        //listar
        public DataTable Loguear(string usuario, string password)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Usuario_Loguear", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pusuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@pclave", SqlDbType.VarChar).Value = password;
                SqlCnx.Open();
                resultado = comando.ExecuteReader();
                Tabla.Load(resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCnx.State == ConnectionState.Open) SqlCnx.Close();
            }
        }
    }
}
