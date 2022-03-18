using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Web.UI.WebControls;
//using SistemaEscritorio.Negocio;
using Negocios;

namespace Presentacion
{
    public partial class frm_mostrarPersona : Form
    {
        public frm_mostrarPersona()
        {
            InitializeComponent();
        }
        private void TitulosGrilla()
        {
            //dgvlistarp.Columns[0].Visible = false; //columna seleccionar
            dgvlistarp.Columns[1].Width = 70;
            dgvlistarp.Columns[2].Width = 120;
            dgvlistarp.Columns[3].Width = 120;
            dgvlistarp.Columns[4].Width = 100;
            dgvlistarp.Columns[5].Width = 100;
            dgvlistarp.Columns[6].Width = 100;
            dgvlistarp.Columns[7].Width = 90;
            dgvlistarp.Columns[8].Width = 150;
            //dgvlistarp.Columns[9].Width = 80;
            //dgvlistarp.Columns[1].HeaderText = "Codigo";
            dgvlistarp.Columns[1].HeaderText = "Dni";
            dgvlistarp.Columns[2].HeaderText = "Nombre";
            dgvlistarp.Columns[3].HeaderText = "Apellido";
            dgvlistarp.Columns[4].HeaderText = "Sexo";
            dgvlistarp.Columns[5].HeaderText = "Email";
            dgvlistarp.Columns[6].HeaderText = "Celular";
            dgvlistarp.Columns[7].HeaderText = "Direccion";
            dgvlistarp.Columns[8].HeaderText = "Fecha Nacimiento";
        }
        private void listargrilla()
        {
            try
            {
                dgvlistarp.DataSource = PersonaNegocio.ListarP();
                this.TitulosGrilla();
                //this.limpiar();
                //this.Visualizar();
                //lbltotal.Text = "Total de registros: " + Convert.ToString(dgvlistarp.Rows.Count);//cuenta filas
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void frm_mostrarPersona_Load(object sender, EventArgs e)
        {
            this.listargrilla();
        }
    }
}
