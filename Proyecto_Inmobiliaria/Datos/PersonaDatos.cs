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
    public class PersonaDatos
    {
        //listar
        public DataTable listarP()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Persona_S", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
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
        public DataTable listarE()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Empleado_S", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
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
        //metodo buscar
        public DataTable BuscarP(string Busqueda)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Persona_S_Buscar", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pbusqueda", SqlDbType.VarChar).Value = Busqueda;
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
        //verificar si existe
        public string ExisteP(string Valor)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Persona_Verificar", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParExiste);
                SqlCnx.Open();
                comando.ExecuteNonQuery();
                rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCnx.State == ConnectionState.Open) SqlCnx.Close();
            }
            return rpta;
        }
        //insertar
        public string InsertarP(Persona objpersona)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Persona_I", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pdni", SqlDbType.Char).Value = objpersona.Dni;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objpersona.Nombres;
                comando.Parameters.Add("@papellido", SqlDbType.Text).Value = objpersona.Apellido;
                comando.Parameters.Add("@psexo", SqlDbType.Char).Value = objpersona.Sexo;
                comando.Parameters.Add("@pemail", SqlDbType.VarChar).Value = objpersona.Email;
                comando.Parameters.Add("@pcelular", SqlDbType.Char).Value = objpersona.Celular;
                comando.Parameters.Add("@pdireccion", SqlDbType.Text).Value = objpersona.Direccion;
                comando.Parameters.Add("@pfechanacimiento", SqlDbType.Date).Value = objpersona.FechaNac;
                SqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar el registro...";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCnx.State == ConnectionState.Open) SqlCnx.Close();
            }
            return rpta;
        }
        public string InsertarE(Persona objpersona)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Persona_E", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pdni", SqlDbType.Char).Value = objpersona.Dni;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objpersona.Nombres;
                comando.Parameters.Add("@papellido", SqlDbType.Text).Value = objpersona.Apellido;
                comando.Parameters.Add("@psexo", SqlDbType.Char).Value = objpersona.Sexo;
                comando.Parameters.Add("@pemail", SqlDbType.VarChar).Value = objpersona.Email;
                comando.Parameters.Add("@pcelular", SqlDbType.Char).Value = objpersona.Celular;
                comando.Parameters.Add("@pdireccion", SqlDbType.Text).Value = objpersona.Direccion;
                comando.Parameters.Add("@pfechanacimiento", SqlDbType.Date).Value = objpersona.FechaNac;
                SqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar el registro...";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCnx.State == ConnectionState.Open) SqlCnx.Close();
            }
            return rpta;
        }
        //actualizar
        public string ActualizarP(Persona objpersona)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Persona_U", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pdni", SqlDbType.Char).Value = objpersona.Dni;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objpersona.Nombres;
                comando.Parameters.Add("@papellido", SqlDbType.Text).Value = objpersona.Apellido;
                comando.Parameters.Add("@psexo", SqlDbType.Char).Value = objpersona.Sexo;
                comando.Parameters.Add("@pemail", SqlDbType.VarChar).Value = objpersona.Email;
                comando.Parameters.Add("@pcelular", SqlDbType.Char).Value = objpersona.Celular;
                comando.Parameters.Add("@pdireccion", SqlDbType.Text).Value = objpersona.Direccion;
                comando.Parameters.Add("@pfechanacimiento", SqlDbType.Date).Value = objpersona.FechaNac;
                SqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar el registro...";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCnx.State == ConnectionState.Open) SqlCnx.Close();
            }
            return rpta;
        }

        //Eliminar
        public string EliminarP(int Id)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Persona_D", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@ppersona_id", SqlDbType.Int).Value = Id;
                SqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se puede eliminar registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCnx.State == ConnectionState.Open) SqlCnx.Close();
            }
            return rpta;
        }
    }
}
