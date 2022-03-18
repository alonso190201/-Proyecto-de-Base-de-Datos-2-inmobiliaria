namespace Presentacion
{
    partial class frm_mostrarPersona
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlistarp
            // 
            this.dgvlistarp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistarp.Location = new System.Drawing.Point(12, 135);
            this.dgvlistarp.Name = "dgvlistarp";
            this.dgvlistarp.Size = new System.Drawing.Size(755, 312);
            this.dgvlistarp.TabIndex = 1;
            // 
            // frm_mostrarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 556);
            this.Controls.Add(this.dgvlistarp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_mostrarPersona";
            this.Text = "frm_mostrarPersona";
            this.Load += new System.EventHandler(this.frm_mostrarPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistarp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistarp;
    }
}