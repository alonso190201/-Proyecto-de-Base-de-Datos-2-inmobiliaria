namespace Presentacion
{
    partial class frm_transacciones
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
            this.panel_contenedor1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompraVenta = new System.Windows.Forms.Button();
            this.btn_inmueble = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_contenedor1
            // 
            this.panel_contenedor1.BackColor = System.Drawing.Color.White;
            this.panel_contenedor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor1.Location = new System.Drawing.Point(0, 0);
            this.panel_contenedor1.Name = "panel_contenedor1";
            this.panel_contenedor1.Size = new System.Drawing.Size(840, 634);
            this.panel_contenedor1.TabIndex = 4;
            this.panel_contenedor1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(60, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "MENU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRANSACCIONES";
            // 
            // btnCompraVenta
            // 
            this.btnCompraVenta.FlatAppearance.BorderSize = 0;
            this.btnCompraVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraVenta.ForeColor = System.Drawing.Color.White;
            this.btnCompraVenta.Location = new System.Drawing.Point(0, 109);
            this.btnCompraVenta.Name = "btnCompraVenta";
            this.btnCompraVenta.Size = new System.Drawing.Size(197, 60);
            this.btnCompraVenta.TabIndex = 7;
            this.btnCompraVenta.Text = "REGISTRAR INMUEBLE";
            this.btnCompraVenta.UseVisualStyleBackColor = true;
            this.btnCompraVenta.Click += new System.EventHandler(this.btnCompraVenta_Click);
            // 
            // btn_inmueble
            // 
            this.btn_inmueble.FlatAppearance.BorderSize = 0;
            this.btn_inmueble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inmueble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inmueble.ForeColor = System.Drawing.Color.White;
            this.btn_inmueble.Location = new System.Drawing.Point(0, 66);
            this.btn_inmueble.Name = "btn_inmueble";
            this.btn_inmueble.Size = new System.Drawing.Size(197, 37);
            this.btn_inmueble.TabIndex = 6;
            this.btn_inmueble.Text = "principal";
            this.btn_inmueble.UseVisualStyleBackColor = true;
            this.btn_inmueble.Visible = false;
            this.btn_inmueble.Click += new System.EventHandler(this.btn_inmueble_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(0, 175);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(197, 61);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "MOSTRAR INMUEBLE";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCompraVenta);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btn_inmueble);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnMostrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(840, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 634);
            this.panel1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 37);
            this.button6.TabIndex = 10;
            this.button6.Text = "principal";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 37);
            this.button5.TabIndex = 9;
            this.button5.Text = "principal";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            // 
            // frm_transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 634);
            this.Controls.Add(this.panel_contenedor1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_transacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_transacciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompraVenta;
        private System.Windows.Forms.Button btn_inmueble;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}