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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoEnfermeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDatosDeEnfermeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEnfermerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermerosXEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoEnfermeroToolStripMenuItem,
            this.actualizarDatosDeEnfermeroToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // registrarNuevoEnfermeroToolStripMenuItem
            // 
            this.registrarNuevoEnfermeroToolStripMenuItem.Name = "registrarNuevoEnfermeroToolStripMenuItem";
            this.registrarNuevoEnfermeroToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.registrarNuevoEnfermeroToolStripMenuItem.Text = "Registrar nuevo enfermero";
            this.registrarNuevoEnfermeroToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoEnfermeroToolStripMenuItem_Click);
            // 
            // actualizarDatosDeEnfermeroToolStripMenuItem
            // 
            this.actualizarDatosDeEnfermeroToolStripMenuItem.Name = "actualizarDatosDeEnfermeroToolStripMenuItem";
            this.actualizarDatosDeEnfermeroToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.actualizarDatosDeEnfermeroToolStripMenuItem.Text = "Actualizar datos de enfermero";
            this.actualizarDatosDeEnfermeroToolStripMenuItem.Click += new System.EventHandler(this.actualizarDatosDeEnfermeroToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarEnfermerosToolStripMenuItem,
            this.listarEspecialidadesToolStripMenuItem});
            this.listadoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listadoToolStripMenuItem.Image")));
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // listarEnfermerosToolStripMenuItem
            // 
            this.listarEnfermerosToolStripMenuItem.Name = "listarEnfermerosToolStripMenuItem";
            this.listarEnfermerosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listarEnfermerosToolStripMenuItem.Text = "Listar Enfermeros";
            this.listarEnfermerosToolStripMenuItem.Click += new System.EventHandler(this.listarEnfermerosToolStripMenuItem_Click);
            // 
            // listarEspecialidadesToolStripMenuItem
            // 
            this.listarEspecialidadesToolStripMenuItem.Name = "listarEspecialidadesToolStripMenuItem";
            this.listarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listarEspecialidadesToolStripMenuItem.Text = "Listar Especialidades";
            this.listarEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.listarEspecialidadesToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enfermerosXEspecialidadToolStripMenuItem});
            this.consultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaToolStripMenuItem.Image")));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // enfermerosXEspecialidadToolStripMenuItem
            // 
            this.enfermerosXEspecialidadToolStripMenuItem.Name = "enfermerosXEspecialidadToolStripMenuItem";
            this.enfermerosXEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.enfermerosXEspecialidadToolStripMenuItem.Text = "Enfermeros x Especialidad";
            this.enfermerosXEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.enfermerosXEspecialidadToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 430);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 452);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermerosXEspecialidadToolStripMenuItem;
    }
}



