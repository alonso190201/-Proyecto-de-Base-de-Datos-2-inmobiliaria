namespace Presentacion
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTransacciones = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVivienda = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.panel_contenedor1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.picSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 46);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(196, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 20);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "label1";
            // 
            // picSalir
            // 
            this.picSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSalir.BackgroundImage")));
            this.picSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSalir.Location = new System.Drawing.Point(1196, 3);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(41, 36);
            this.picSalir.TabIndex = 2;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.btnTransacciones);
            this.panel2.Controls.Add(this.btnMantenimiento);
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnVivienda);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.btnConsultas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 634);
            this.panel2.TabIndex = 9;
            // 
            // btnTransacciones
            // 
            this.btnTransacciones.FlatAppearance.BorderSize = 0;
            this.btnTransacciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacciones.ForeColor = System.Drawing.Color.White;
            this.btnTransacciones.Location = new System.Drawing.Point(3, 87);
            this.btnTransacciones.Name = "btnTransacciones";
            this.btnTransacciones.Size = new System.Drawing.Size(197, 37);
            this.btnTransacciones.TabIndex = 7;
            this.btnTransacciones.Text = "TRANSACCIONES";
            this.btnTransacciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransacciones.UseVisualStyleBackColor = true;
            this.btnTransacciones.Click += new System.EventHandler(this.btnTransacciones_Click);
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.FlatAppearance.BorderSize = 0;
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.ForeColor = System.Drawing.Color.White;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 44);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(197, 37);
            this.btnMantenimiento.TabIndex = 2;
            this.btnMantenimiento.Text = "MANTENIMIENTO";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Enabled = false;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(0, 173);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(197, 37);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnVivienda
            // 
            this.btnVivienda.Enabled = false;
            this.btnVivienda.FlatAppearance.BorderSize = 0;
            this.btnVivienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVivienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVivienda.ForeColor = System.Drawing.Color.White;
            this.btnVivienda.Location = new System.Drawing.Point(0, 1);
            this.btnVivienda.Name = "btnVivienda";
            this.btnVivienda.Size = new System.Drawing.Size(197, 37);
            this.btnVivienda.TabIndex = 1;
            this.btnVivienda.Text = "INMUEBLES";
            this.btnVivienda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVivienda.UseVisualStyleBackColor = true;
            this.btnVivienda.Click += new System.EventHandler(this.btnVivienda_Click);
            // 
            // lblHora
            // 
            this.lblHora.AllowDrop = true;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(12, 562);
            this.lblHora.Name = "lblHora";
            this.lblHora.Padding = new System.Windows.Forms.Padding(1);
            this.lblHora.Size = new System.Drawing.Size(99, 44);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "hora";
            // 
            // btnConsultas
            // 
            this.btnConsultas.Enabled = false;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Location = new System.Drawing.Point(0, 130);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(197, 37);
            this.btnConsultas.TabIndex = 4;
            this.btnConsultas.Text = "CONSULTAS";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // panel_contenedor1
            // 
            this.panel_contenedor1.BackColor = System.Drawing.Color.White;
            this.panel_contenedor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor1.Location = new System.Drawing.Point(200, 46);
            this.panel_contenedor1.Name = "panel_contenedor1";
            this.panel_contenedor1.Size = new System.Drawing.Size(1040, 634);
            this.panel_contenedor1.TabIndex = 10;
            this.panel_contenedor1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 680);
            this.Controls.Add(this.panel_contenedor1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_principal";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTransacciones;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVivienda;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Panel panel_contenedor1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblUser;
    }
}