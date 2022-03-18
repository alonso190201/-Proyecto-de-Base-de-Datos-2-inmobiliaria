using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using SistemaEscritorio.Entidad;
//using SistemaEscritorio.Datos;
using Datos;

namespace Negocios
{
    public class UsuarioNegocio
    {
        //metodo loguear
        public static DataTable loguear(string usuario, string password)
        {
            UsuarioDatos objusuario = new UsuarioDatos();
            return objusuario.Loguear(usuario, password);
        }
    }
}
