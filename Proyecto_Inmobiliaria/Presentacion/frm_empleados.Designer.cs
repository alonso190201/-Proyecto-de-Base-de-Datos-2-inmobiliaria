namespace Presentacion
{
    partial class frm_empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpfechanac = new System.Windows.Forms.DateTimePicker();
            this.cbosexo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.erroralerta = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erroralerta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(336, 414);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 86;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(417, 414);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(255, 414);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 84;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtcelular
            // 
            this.txtcelular.Location = new System.Drawing.Point(339, 291);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(157, 20);
            this.txtcelular.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 82;
            this.label11.Text = "CELULAR :";
            // 
            // dtpfechanac
            // 
            this.dtpfechanac.Location = new System.Drawing.Point(392, 367);
            this.dtpfechanac.Name = "dtpfechanac";
            this.dtpfechanac.Size = new System.Drawing.Size(247, 20);
            this.dtpfechanac.TabIndex = 81;
            this.dtpfechanac.Value = new System.DateTime(1995, 12, 29, 0, 0, 0, 0);
            // 
            // cbosexo
            // 
            this.cbosexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosexo.FormattingEnabled = true;
            this.cbosexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbosexo.Location = new System.Drawing.Point(339, 232);
            this.cbosexo.Name = "cbosexo";
            this.cbosexo.Size = new System.Drawing.Size(70, 21);
            this.cbosexo.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "FECHA NACIMIENTO :";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(339, 317);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(157, 20);
            this.txtdireccion.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 77;
            this.label9.Text = "DIRECCION :";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(339, 265);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(157, 20);
            this.txtemail.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "EMAIL :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "SEXO :";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(339, 196);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(157, 20);
            this.txtapellidos.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "APELLIDO :";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(339, 157);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(157, 20);
            this.txtnombre.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "NOMBRE :";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(339, 122);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(157, 20);
            this.txtdni.TabIndex = 69;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(339, 80);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(58, 20);
            this.txtcodigo.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "DNI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Codigo:";
            // 
            // erroralerta
            // 
            this.erroralerta.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 87;
            this.label1.Text = "EMPLEADOS";
            // 
            // frm_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 634);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtcelular);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpfechanac);
            this.Controls.Add(this.cbosexo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_empleados";
            this.Text = "frm_empleados";
            this.Load += new System.EventHandler(this.frm_empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erroralerta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpfechanac;
        private System.Windows.Forms.ComboBox cbosexo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider erroralerta;
        private System.Windows.Forms.Label label1;
    }
}