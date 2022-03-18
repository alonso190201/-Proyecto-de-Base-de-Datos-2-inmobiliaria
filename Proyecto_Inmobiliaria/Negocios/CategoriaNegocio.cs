using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using SistemaEscritorio.Datos;
//using SistemaEscritorio.Entidad;
using System.Data;
using System.Data.SqlClient;
using Entidad;
using Datos;

namespace Negocios
{
    class CategoriaNegocio
    {
        //metodo listar
        public static DataTable Listar()
        {
            CategoriaDatos objcategoria = new CategoriaDatos();
            return objcategoria.listar();
        }

        //buscar
        public static DataTable Buscar(string busqueda)
        {
            CategoriaDatos objcategoria = new CategoriaDatos();
            return objcategoria.Buscar(busqueda);
        }

        //insertar
        public static string Insertar(string nombre, string descripcion, string estado)
        {
            CategoriaDatos objcategoria = new CategoriaDatos();
            string Existe = objcategoria.Existe(nombre);
            if (Existe.Equals("1"))
            {
                return "La categoria ya existe en la base de datos";
            }
            else
            {
                Categoria objcategoriaE = new Categoria();
                objcategoriaE.Nombre = nombre;
                objcategoriaE.Descripcion = descripcion;
                objcategoriaE.Estado = estado;
                return objcategoria.Insertar(objcategoriaE);
            }
        }

        //actualizar
        public static string Actualizar(int Id, string NombreAnterior, string nombre, string descripcion, string estado)
        {
            CategoriaDatos objcategoria = new CategoriaDatos();
            Categoria obj = new Categoria();
            if (NombreAnterior.Equals(nombre))
            {
                obj.CategoriaId = Id;
                obj.Nombre = nombre;
                obj.Descripcion = descripcion;
                obj.Estado = estado;
                return objcategoria.Actualizar(obj);
            }
            else
            {
                string Existe = objcategoria.Existe(nombre);
                if (Existe.Equals("1"))
                {
                    return "La categoria ya existe en la base de datos";
                }
                else
                {
                    Categoria objcategoriaE = new Categoria();
                    objcategoriaE.CategoriaId = Id;
                    objcategoriaE.Nombre = nombre;
                    objcategoriaE.Descripcion = descripcion;
                    objcategoriaE.Estado = estado;
                    return objcategoria.Actualizar(objcategoriaE);
                }
            }

        }

        //eliminar
        public static string Eliminar(int Id)
        {
            CategoriaDatos objcategoria = new CategoriaDatos();
            return objcategoria.Eliminar(Id);
        }
        //Activar
        public static string Activar(int Id)
        {
            CategoriaDatos objcategoria = new CategoriaDatos();
            return objcategoria.Activar(Id);
        }

        //Desactivar
        public static string Desactivar(int Id)
        {
            CategoriaDatos objcategoria = new CategoriaDatos();
            return objcategoria.Desactivar(Id);
        }
    }
}
