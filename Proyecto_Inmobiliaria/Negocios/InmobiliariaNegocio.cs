using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using Entidad;

namespace Negocios
{
    public class InmobiliariaNegocio
    {
        //metodo listar
        public static DataTable ListarP()
        {
            InmobiliariaDatos objinmueble = new InmobiliariaDatos();
            return objinmueble.listarP();
        }
        //buscar
        //public static DataTable BuscarP(string busqueda)
        //{
        //    PersonaDatos objpersona = new PersonaDatos();
        //    return objpersona.BuscarP(busqueda);
        //}
        //insertar
        public static string InsertarP(string dni, string nombre, string apellido, string celular, string direccion, string tipo)
        {
            InmobiliariaDatos objinmueble = new InmobiliariaDatos();
            string Existe = objinmueble.ExisteP(nombre);
            if (Existe.Equals("1"))
            {
                return "El inmueble ya existe en la base de datos";
            }
            else
            {
                ClsInmueble objpersonaE = new ClsInmueble();
                objpersonaE.Dni = dni;
                objpersonaE.Nombre = nombre;
                objpersonaE.Apellido = apellido;
                objpersonaE.Celular = celular;
                objpersonaE.Tipoinmueble = tipo;
                objpersonaE.Direccion = direccion;               
                return objinmueble.InsertarP(objpersonaE);
            }
    }
        //actualizar
        //public static string ActualizarP(int id, string dni, string dnianterior, string nombre, string apellido, string sexo, string email, string celular, string direccion, string fechanac)
        //{
        //    PersonaDatos objpersona = new PersonaDatos();
        //    Persona obj = new Persona();
        //    if (dnianterior.Equals(nombre))
        //    {
        //        obj.PersonaId = id;
        //        obj.Dni = dni;
        //        obj.Nombres = nombre;
        //        obj.Apellido = apellido;
        //        obj.Sexo = sexo;
        //        obj.Email = email;
        //        obj.Celular = celular;
        //        obj.Direccion = direccion;
        //        obj.FechaNac = fechanac;
        //        return objpersona.ActualizarP(obj);
        //    }
        //    else
        //    {
        //        string Existe = objpersona.ExisteP(nombre);
        //        if (Existe.Equals("1"))
        //        {
        //            return "La Persona ya existe en la base de datos";
        //        }
        //        else
        //        {
        //            Persona objpersonaE = new Persona();
        //            objpersonaE.Dni = dni;
        //            objpersonaE.Nombres = nombre;
        //            objpersonaE.Apellido = apellido;
        //            objpersonaE.Sexo = sexo;
        //            objpersonaE.Email = email;
        //            objpersonaE.Celular = celular;
        //            objpersonaE.Direccion = direccion;
        //            objpersonaE.FechaNac = fechanac;
        //            return objpersona.InsertarP(objpersonaE);
        //        }
        //    }
        //}

        //eliminar
        public static string EliminarP(int Id)
        {
            PersonaDatos objpersona = new PersonaDatos();
            return objpersona.EliminarP(Id);
        }
    }
}
