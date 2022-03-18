using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//using Presentacion;

namespace Presentacion
{
    public partial class frm_principal : Form
    {
        public int IIdUsuario;
        public string Apellido, Nombre, Usuario, Nivel, Estado;
        public frm_principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblUser.Text = "Bienvenido: " + Nombre + " " + Apellido + ", Nivel: [" + Nivel + "]";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void picSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_contenedor1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVivienda_Click(object sender, EventArgs e)
        {

        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_mantenimiento>();
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frm_transacciones>();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<frm_Consultas>();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            //AbrirFormulario<frm_reportes>();
        }
    }
}
