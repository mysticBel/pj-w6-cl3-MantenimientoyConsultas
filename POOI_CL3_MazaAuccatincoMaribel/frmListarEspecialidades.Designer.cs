namespace POOI_CL3_MazaAuccatincoMaribel
{
    partial class frmListarEspecialidades
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
            this.dgEspecialidades = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecialidades)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEspecialidades
            // 
            this.dgEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEspecialidades.Location = new System.Drawing.Point(44, 108);
            this.dgEspecialidades.Name = "dgEspecialidades";
            this.dgEspecialidades.Size = new System.Drawing.Size(719, 300);
            this.dgEspecialidades.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTADO DE ESPECIALIDADES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgEspecialidades);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 456);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(114, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 73);
            this.panel2.TabIndex = 4;
            // 
            // frmListarEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmListarEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarEspecialidades";
            this.Load += new System.EventHandler(this.frmListarEspecialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEspecialidades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEspecialidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}