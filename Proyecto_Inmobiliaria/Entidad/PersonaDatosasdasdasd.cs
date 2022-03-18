using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidad
{
    class PersonaDatosasdasdasd
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Persona_S", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCnx.Open();
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
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
        }


        //Metodo Buscar
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Persona_S_Buscar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
                sqlCnx.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open)
                {
                    sqlCnx.Close();
                }
            }
        }

        //metodo Eliminar
        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Persona_D", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@apersona_id", SqlDbType.Int).Value = Id;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Eliminar el Registro...";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;

            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }

        //metodo Actulizar
        //public string Actualizar(Persona objPersona)
        //{
        //    string Rpta = "";
        //    SqlConnection sqlCnx = new SqlConnection();
        //    try
        //    {
        //        sqlCnx = Conexion.getIntancia().EstablecerConexion();
        //        SqlCommand comando = new SqlCommand("USP_Persona_U", sqlCnx);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.Add("@apersona_id", SqlDbType.VarChar).Value = objPersona.PersonaId;
        //        comando.Parameters.Add("@adni", SqlDbType.VarChar).Value = objPersona.Dni;
        //        comando.Parameters.Add("@anombre", SqlDbType.VarChar).Value = objPersona.Nombre;
        //        comando.Parameters.Add("@aapellido", SqlDbType.VarChar).Value = objPersona.Apellido;
        //        comando.Parameters.Add("@asexo", SqlDbType.VarChar).Value = objPersona.Sexo;
        //        comando.Parameters.Add("@aemail", SqlDbType.VarChar).Value = objPersona.Email;
        //        comando.Parameters.Add("@acelular", SqlDbType.VarChar).Value = objPersona.Celular;
        //        comando.Parameters.Add("@adireccion", SqlDbType.VarChar).Value = objPersona.Direccion;
        //        comando.Parameters.Add("@afechanacimiento", SqlDbType.Date).Value = objPersona.FechaNac;
        //        sqlCnx.Open();
        //        Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Actualizar el Registro...";
        //    }
        //    catch (Exception ex)
        //    {
        //        Rpta = ex.Message;

        //    }
        //    finally
        //    {
        //        if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
        //    }
        //    return Rpta;

        //}

        //metodo insertar
        //public string Insertar(Persona objPersona)
        //{
        //    string Rpta = "";
        //    SqlConnection sqlCnx = new SqlConnection();
        //    try
        //    {
        //        sqlCnx = Conexion.getIntancia().EstablecerConexion();
        //        SqlCommand comando = new SqlCommand("USP_Persona_I", sqlCnx);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.Add("@apersona_id", SqlDbType.VarChar).Value = objPersona.PersonaId;
        //        comando.Parameters.Add("@adni", SqlDbType.VarChar).Value = objPersona.Dni;
        //        comando.Parameters.Add("@anombre", SqlDbType.VarChar).Value = objPersona.Nombre;
        //        comando.Parameters.Add("@aapellido", SqlDbType.VarChar).Value = objPersona.Apellido;
        //        comando.Parameters.Add("@asexo", SqlDbType.VarChar).Value = objPersona.Sexo;
        //        comando.Parameters.Add("@aemail", SqlDbType.VarChar).Value = objPersona.Email;
        //        comando.Parameters.Add("@acelular", SqlDbType.VarChar).Value = objPersona.Celular;
        //        comando.Parameters.Add("@adireccion", SqlDbType.VarChar).Value = objPersona.Direccion;
        //        comando.Parameters.Add("@afechanacimiento", SqlDbType.Date).Value = objPersona.FechaNac;

        //        sqlCnx.Open();
        //        Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Agregar el Registro...";
        //    }
        //    catch (Exception ex)
        //    {
        //        Rpta = ex.Message;

        //    }
        //    finally
        //    {
        //        if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
        //    }
        //    return Rpta;
        //}

        // metodo Existe
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Persona_Verificar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParExiste);
                sqlCnx.Open();
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;

            }
            finally
            {
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
            return Rpta;
        }
    }
}
