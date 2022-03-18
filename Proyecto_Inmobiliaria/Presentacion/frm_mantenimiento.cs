using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_mantenimiento : Form
    {
        public frm_mantenimiento()
        {
            InitializeComponent();
        }

        private void frm_mantenimiento_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form formulario = panel_contenedor1.Controls.OfType<T>().FirstOrDefault();
            if (formulario != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                formulario.BringToFront();
                return;
            }
            //Se abre el form
            formulario = new T();
            formulario.TopLevel = false;
            panel_contenedor1.Controls.Add(formulario);
            panel_contenedor1.Tag = formulario;
            formulario.Show();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_clientes>();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_empleados>();
        }

        private void panel_contenedor1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_mostrarpersona_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_mostrarPersona>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_mostrarempleado>();
        }
    }
}
