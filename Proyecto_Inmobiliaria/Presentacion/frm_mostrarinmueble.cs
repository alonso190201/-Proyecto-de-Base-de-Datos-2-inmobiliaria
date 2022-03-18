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
    public partial class frm_mostrarinmueble : Form
    {
        public frm_mostrarinmueble()
        {
            InitializeComponent();
        }
        private void TitulosGrilla()
        {
            //dgvlistarp.Columns[0].Visible = false; //columna seleccionar
            //dgvlistarp.Columns[0].Width = 30;
            dgvlistarp.Columns[1].Width = 80;
            dgvlistarp.Columns[2].Width = 140;
            dgvlistarp.Columns[3].Width = 140;
            dgvlistarp.Columns[4].Width = 80;
            dgvlistarp.Columns[5].Width = 60;
            dgvlistarp.Columns[6].Width = 150;
            //dgvlistarp.Columns[7].Width = 140;
            //dgvlistarp.Columns[7].Width = 140;
            //dgvlistarp.Columns[1].HeaderText = "Codigo";
            dgvlistarp.Columns[1].HeaderText = "Dni";
            dgvlistarp.Columns[2].HeaderText = "Nombre";
            dgvlistarp.Columns[3].HeaderText = "Apellido";
            dgvlistarp.Columns[4].HeaderText = "Celular";
            dgvlistarp.Columns[5].HeaderText = "Tipo";
            dgvlistarp.Columns[6].HeaderText = "Direccion";
            
        }
        private void limpiar()
        {
            //txtidpersona.Text = "";
            //txtnombre.Clear();
            //txtapellidos.Clear();
            //txtdireccion.Clear();
            //txtcelular.Clear();
            //txtemail.Clear();
        }

        private void listargrilla()
        {
            try
            {
                dgvlistarp.DataSource = InmobiliariaNegocio.ListarP();
                this.TitulosGrilla();
                this.limpiar();
                //this.Visualizar();
                //lbltotal.Text = "Total de registros: " + Convert.ToString(dgvlistarp.Rows.Count);//cuenta filas
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void frm_mostrarinmueble_Load(object sender, EventArgs e)
        {
            this.listargrilla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            
            this.listargrilla();

        }
    }
}
