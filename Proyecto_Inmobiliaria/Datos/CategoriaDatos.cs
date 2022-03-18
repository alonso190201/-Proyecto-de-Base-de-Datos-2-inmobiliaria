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
    public class CategoriaDatos
    {
        public DataTable listar()
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();

            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_S", SqlCnx);
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
        public DataTable Buscar(string Busqueda)
        {
            SqlDataReader resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_S_Buscar", SqlCnx);
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
        public string Existe(string Valor)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_Verificar", SqlCnx);
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
        public string Insertar(Categoria objcategoria)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_I", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objcategoria.Nombre;
                comando.Parameters.Add("@pdescripcion", SqlDbType.Text).Value = objcategoria.Descripcion;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objcategoria.Estado;
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
        public string Actualizar(Categoria objcategoria)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_U", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pcategoria_id", SqlDbType.Int).Value = objcategoria.CategoriaId;
                comando.Parameters.Add("@pnombre", SqlDbType.VarChar).Value = objcategoria.Nombre;
                comando.Parameters.Add("@pdescripcion", SqlDbType.Text).Value = objcategoria.Descripcion;
                comando.Parameters.Add("@pestado", SqlDbType.Char).Value = objcategoria.Estado;
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
        public string Eliminar(int Id)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_D", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pcategoria_id", SqlDbType.Int).Value = Id;
                SqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar registro";

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
        //activar
        public string Activar(int Id)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_Activar", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pcategoria_id", SqlDbType.Int).Value = Id;
                SqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el registro";

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
        public string Desactivar(int Id)
        {
            string rpta = "";
            SqlConnection SqlCnx = new SqlConnection();
            try
            {
                SqlCnx = Conexion.GetInstancia().Establecerconexion();
                SqlCommand comando = new SqlCommand("USP_Categoria_Desactivar", SqlCnx);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@pcategoria_id", SqlDbType.Int).Value = Id;
                SqlCnx.Open();
                rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo desactivar el registro";

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
