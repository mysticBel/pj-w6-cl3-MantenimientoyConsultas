namespace POOI_CL3_MazaAuccatincoMaribel
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEnfermerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoEnfermeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosDeEnfermeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoEnfermeroToolStripMenuItem,
            this.actualizarDatosDeEnfermeroToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarEnfermerosToolStripMenuItem,
            this.listarEspecialidadesToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // listarEnfermerosToolStripMenuItem
            // 
            this.listarEnfermerosToolStripMenuItem.Name = "listarEnfermerosToolStripMenuItem";
            this.listarEnfermerosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listarEnfermerosToolStripMenuItem.Text = "Listar Enfermeros";
            // 
            // listarEspecialidadesToolStripMenuItem
            // 
            this.listarEspecialidadesToolStripMenuItem.Name = "listarEspecialidadesToolStripMenuItem";
            this.listarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listarEspecialidadesToolStripMenuItem.Text = "Listar Especialidades";
            // 
            // registrarNuevoEnfermeroToolStripMenuItem
            // 
            this.registrarNuevoEnfermeroToolStripMenuItem.Name = "registrarNuevoEnfermeroToolStripMenuItem";
            this.registrarNuevoEnfermeroToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.registrarNuevoEnfermeroToolStripMenuItem.Text = "Registrar nuevo enfermero";
            // 
            // actualizarDatosDeEnfermeroToolStripMenuItem
            // 
            this.actualizarDatosDeEnfermeroToolStripMenuItem.Name = "actualizarDatosDeEnfermeroToolStripMenuItem";
            this.actualizarDatosDeEnfermeroToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.actualizarDatosDeEnfermeroToolStripMenuItem.Text = "Actualizar datos de enfermero";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoEnfermeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDatosDeEnfermeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEnfermerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}



