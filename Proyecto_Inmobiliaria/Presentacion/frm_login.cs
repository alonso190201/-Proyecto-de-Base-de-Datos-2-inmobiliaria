using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                string Usuario, Password;
                Usuario = txtusuario.Text.Trim();
                Password = txtpassword.Text.Trim();

                DataTable Tabla = new DataTable();
                Tabla = UsuarioNegocio.loguear(Usuario, Password);

                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El Usuario no esta registrado en la BD...", "Autenticacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToString(Tabla.Rows[0][6]) == "I")
                    {
                        MessageBox.Show("El Usuario se encuentra inhabilitado,consulte con el administrador...", "Autenticacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        frm_principal frm = new frm_principal();
                        //MDIPrincipal MDI = new MDIPrincipal();
                        frm.IIdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);//idusuario
                        //MDI.IIdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);//idusuario
                        frm.Apellido = Convert.ToString(Tabla.Rows[0][1]);//apellido
                        frm.Nombre = Convert.ToString(Tabla.Rows[0][2]);//nombre
                        frm.Usuario = Convert.ToString(Tabla.Rows[0][4]);//usuario
                        frm.Nivel = Convert.ToString(Tabla.Rows[0][5]);//nivel
                        frm.Estado = Convert.ToString(Tabla.Rows[0][6]);//estado
                        frm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
