using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidad
{
    public class CategoriaDatosasdasdasd
    {
        public DataTable Listar()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_S", sqlCnx);
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

        // metodo buscar 

        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection sqlCnx = new SqlConnection();

            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_S_Buscar", sqlCnx);
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
                if (sqlCnx.State == ConnectionState.Open) sqlCnx.Close();
            }
        }

        // metodo verificar si existe

        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_Verificar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pvalor", SqlDbType.VarChar).Value = Valor;
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

        //metodo insertar

        //public string Insertar(Categoria objcategoria)
        //{
        //    string Rpta = "";
        //    SqlConnection sqlCnx = new SqlConnection();
        //    try
        //    {
        //        sqlCnx = Conexion.getIntancia().EstablecerConexion();
        //        SqlCommand comando = new SqlCommand("USP_Categoria_I", sqlCnx);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objcategoria.Nombre;
        //        comando.Parameters.Add("@pdescripcion", SqlDbType.Text).Value = objcategoria.Descripcion;
        //        comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objcategoria.Estado;
        //        sqlCnx.Open();
        //        Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar el registro...";

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

        ////metodo actualizar

        //public string Actualizar(Categoria objcategoria)
        //{
        //    string Rpta = "";
        //    SqlConnection sqlCnx = new SqlConnection();
        //    try
        //    {
        //        sqlCnx = Conexion.getIntancia().EstablecerConexion();
        //        SqlCommand comando = new SqlCommand("USP_Categoria_U", sqlCnx);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.Add("@pcategoria_id", SqlDbType.Int).Value = objcategoria.CategoriaId;
        //        comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objcategoria.Nombre;
        //        comando.Parameters.Add("@pdescripcion", SqlDbType.Text).Value = objcategoria.Descripcion;
        //        comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objcategoria.Estado;
        //        sqlCnx.Open();
        //        Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro...";

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

        //metodo eliminar

        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_D", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pcategoria_id", SqlDbType.Int).Value = Id;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro...";

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

        //metodo activar
        public string Activar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_Activar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pcategoria_id", SqlDbType.Int).Value = Id;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro...";

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

        //metodo desactivar
        public string Desactivar(int Id)
        {
            string Rpta = "";
            SqlConnection sqlCnx = new SqlConnection();
            try
            {
                sqlCnx = Conexion.getIntancia().EstablecerConexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_Desactivar", sqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pcategoria_id", SqlDbType.Int).Value = Id;
                sqlCnx.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro...";

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
