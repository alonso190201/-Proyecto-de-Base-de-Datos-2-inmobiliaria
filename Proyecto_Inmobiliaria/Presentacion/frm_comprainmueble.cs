﻿using System;
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
    public partial class frm_comprainmueble : Form
    {
        public frm_comprainmueble()
        {
            InitializeComponent();
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //metodo mensaje CORRECTO
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtdni.Text == string.Empty && txtnombre.Text == string.Empty && txtapellidos.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos...");
                    erroralerta.SetError(txtdni, "Ingrese Inmueble");
                }
                else
                {
                    rpta = InmobiliariaNegocio.InsertarP(txtdni.Text.Trim(), txtnombre.Text.Trim(), txtapellidos.Text.Trim(), txtcelular.Text.Trim(), txtdireccion.Text.Trim(), cbtipo.SelectedItem.ToString());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se grabo el registro correctamente...");
                        //this.limpiar();
                        //this.Visualizar();
                        //this.listargrilla();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frm_comprainmueble_Load(object sender, EventArgs e)
        {

        }
    }
}
