namespace Presentacion
{
    partial class frm_mostrarinmueble
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
            this.dgvlistarp = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistarp
            // 
            this.dgvlistarp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistarp.Location = new System.Drawing.Point(12, 135);
            this.dgvlistarp.Name = "dgvlistarp";
            this.dgvlistarp.Size = new System.Drawing.Size(800, 320);
            this.dgvlistarp.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(669, 487);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(111, 42);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Actualizar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frm_mostrarinmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 595);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvlistarp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_mostrarinmueble";
            this.Text = "frm_mostrarinmueble";
            this.Load += new System.EventHandler(this.frm_mostrarinmueble_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistarp;
        private System.Windows.Forms.Button btnCerrar;
    }
}