using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOI_CL3_MazaAuccatincoMaribel
{
    public partial class MenuPrincipal : Form
    {
        private int childFormNumber = 0;

        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void registrarNuevoEnfermeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmNuevoEnfermero childForm = new frmNuevoEnfermero();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void actualizarDatosDeEnfermeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmActualizarEnfermero childForm = new frmActualizarEnfermero();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void listarEnfermerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmListarEnfermeros childForm = new frmListarEnfermeros();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void listarEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm1 in MdiChildren)
            {
                childForm1.Close();
            }
            frmListarEspecialidades childForm = new frmListarEspecialidades();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }
}
